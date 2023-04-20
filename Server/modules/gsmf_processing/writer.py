import base64
from datetime import datetime
from gsmf_processor.languages_parameters import SUPPORTED_LANGUAGES
from gsmf_processor.words_processing import translate_words
from gsmf_processor.words_processing import get_wordinfo_en
from gsmf_processor.words_processing import is_wordlist_valid

def parse_json(request_json):
    """Gets main parameters from request json"""
    author = request_json["author"]
    title = request_json["title"]
    wlang = request_json["wlang"]
    date = request_json["date"]
    words_list = request_json["wlist"]
    translations_list = request_json["translations"]
    cover = request_json["cover"]

    return author, title, wlang.lower(), date, words_list, translations_list, cover


def convert_to_base64(file_path):
    """Converts module file to base64 format"""
    with open(file_path, "rb") as module_file:
        return base64.b64encode(module_file.read())


def create_module(request_json):
    """Creates study module file with gsmf format"""
    author, title, wlang, date, words_list, translations_list, cover = parse_json(request_json)

    if not is_wordlist_valid(words_list):
        return {
            "status": 408,
            "description": "There is something wrong in your word list!",
            "module": ""
        }


    translation_mode = "auto" if not len(translations_list) else "hands"

    filename = generate_name(wlang, author, title)

    with open(filename, "a", encoding="utf-8") as module_file:
        write_init(module_file, author, title, wlang, date, translation_mode, cover)
        write_wordlist(module_file, words_list)
        write_translations(module_file, wlang, words_list)
        write_words_info(module_file, words_list)
        module_file.write("</gsmf>")
    return {
            "status": 200,
            "description": "The Module was Successfully created!",
            "module": f"{convert_to_base64(filename)}"
        }


def generate_name(wlang, author, title):
    """Generates filename by author name and word's language"""
    return f"{wlang}_{author}_{title}_{str(datetime.timestamp(datetime.now())).replace('.', '')}.gsmf".lower()


def write_init(module_file, author, title, wlang, date, trfillmode, cover):
    """Writes init block to the study module file"""
    module_file.write("<gsmf>\n")
    module_file.write("  <init>\n")
    module_file.write(f"    <author>{author}</author>\n")
    module_file.write(f"    <title>{title}</title>\n")
    module_file.write(f"    <wlang>{wlang}</wlang>\n")
    module_file.write(f"    <date>{date}</date>\n")
    module_file.write(f"    <trfillmode>{trfillmode}</trfillmode>\n")
    module_file.write(f"    <cover>{cover}</cover>\n")
    module_file.write(f" </init>\n")


def write_wordlist(module_file, word_list):
    """Writes list of words for learning"""
    module_file.write(" <wlist>\n")
    for word in word_list:
        module_file.write(f"    <word>{word}</word>\n")
    module_file.write(' </wlist>' + '\n')


def write_translations(module_file, source_language, word_list):
    """Writes translations from source language to other supported ones"""
    module_file.write(" <translations>\n")
    for i in SUPPORTED_LANGUAGES:
        if i == source_language:
            continue
        module_file.write(f"    <{i}>\n")
        translated = translate_words(source_lang=source_language, dist_lang=i, words=word_list)
        for j in translated:
            module_file.write(f"        <tr>{j[1:] if j.startswith(' ') else j}</tr>\n")
        module_file.write(f"    </{i}>\n")
    module_file.write(" </translations>\n")


def write_words_info(module_file, wordlist):
    """Writes study info about the words"""
    audio = []
    g_examples = []
    g_definitions = []
    for i in wordlist:
        pronunciation, definitions, examples = get_wordinfo_en(i)
        audio.append(pronunciation)
        g_examples.append(examples)
        g_definitions.append(definitions)
    write_audio_info(module_file, audio)
    write_definitions(module_file, g_definitions)
    write_examples(module_file, g_examples)


def write_audio_info(module_file, audio):
    """Writes audio of pronunciation into the module file"""
    module_file.write(" <audio>\n")
    for i in audio:
        module_file.write(f'     <spk>{i}</spk>\n')
    module_file.write(" </audio>\n")


def write_definitions(module_file, definitions):
    """Writes definitions for words into the module file"""
    module_file.write(" <definitions>\n")
    for word in definitions:
        module_file.write("     <wdblock>\n")
        for df in word:
            module_file.write(f"        <df>{df}</df>\n")
        module_file.write("     </wdlbock>\n")
    module_file.write(" </definitions>\n")


def write_examples(module_file, examples):
    """Writes Examples for Words into the module file"""
    module_file.write(" <examples>\n")
    for word in examples:
        module_file.write("     <exblock>\n")
        for example in word:
            module_file.write(f"        <ex>{example}</ex>\n")
        module_file.write("     </exblock>\n")
    module_file.write(" </examples>\n")
