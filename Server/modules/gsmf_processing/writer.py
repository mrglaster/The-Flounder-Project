import base64
import random
import string
from PIL import Image
from datetime import date
import unicodedata
import io
import re
from datetime import datetime

import modules.database_processing.modules_processing
from modules.gsmf_processing.languages_parameters import SUPPORTED_LANGUAGES
from modules.gsmf_processing.words_processing import translate_words
from modules.gsmf_processing.words_processing import get_wordinfo_en
from modules.gsmf_processing.words_processing import is_wordlist_valid
from modules.database_processing.modules_processing import add_module_to_database


def generate_random_string(length=20):
    """Generates random string of selected length"""
    letters_and_digits = string.ascii_letters + string.digits
    return ''.join(random.choice(letters_and_digits) for i in range(length))


def _array_to_string(arr):
    """Converts array to the string with separator"""
    return ';'.join([word.lower() for word in arr])


def parse_json(request_json):
    """Gets main parameters from request json"""
    author = request_json["author"]
    title = request_json["title"]
    wlang = request_json["language"]
    words_list = request_json["wordlist"]
    translations_list = request_json["translations"]
    trlang = request_json["translations_language"]
    cover = request_json["icon"]
    tags = request_json["tags"]
    description = request_json["description"]
    cur_date = date.today()
    return author, title, wlang.lower(), cur_date, words_list, translations_list, cover, tags, description, trlang


def convert_to_base64(file_path):
    """Converts module file to base64 format"""
    with open(file_path, "rb") as module_file:
        return str(base64.b64encode(module_file.read())).replace("b'", '').replace("'", '')


def create_module(connection, request_json):
    """Creates study module file with gsmf format"""
    author, title, wlang, cur_date, words_list, translations_list, cover, tags, description, trlang = parse_json(
        request_json)

    if modules.database_processing.modules_processing.check_title(connection, title):
        return {"status": 52, "description": "There is already a module with such name!"}

    if modules.database_processing.database_modules.get_userid(connection, author) is None:
        return {"status": 500, "description": "Unknown Username!"}

    if not is_wordlist_valid(words_list):
        return {
            "status": 408,
            "description": "There is something wrong in your word list!",
            "module": ""
        }

    translation_mode = "auto" if not len(translations_list) else "hands"

    filename = generate_name(wlang, author, title)

    with open(filename, "a", encoding="utf-8") as module_file:
        write_init(module_file, author, title, wlang, cur_date, translation_mode, cover)
        write_wordlist(module_file, words_list)
        write_translations(module_file, wlang, words_list, translations=translations_list, trlang=trlang)
        write_words_info(module_file, words_list)
        module_file.write("</gsmf>")

    cover_path = 'data/images/default_cover.png'
    if 'default' not in cover:
        cover_path = f'data/images/{generate_random_string(20)}.png'
        image_bytes = base64.b64decode(cover)
        img_io = io.BytesIO(image_bytes)
        img = Image.open(img_io)
        img.save(cover_path, "PNG")

    add_module_to_database(connection=connection,
                           author_name=author,
                           title=title,
                           description=description,
                           language=wlang,
                           tags=_array_to_string(tags).lower(),
                           wordlist=_array_to_string(words_list).lower(),
                           module_file=filename,
                           icon=cover_path)

    return {
        "status": 200,
        "description": "The Module was Successfully created!",
        "module": f"{convert_to_base64(filename)}"
    }


def slugify(value, allow_unicode=False):
    """
    Taken from https://github.com/django/django/blob/master/django/utils/text.py
    Convert to ASCII if 'allow_unicode' is False. Convert spaces or repeated
    dashes to single dashes. Remove characters that aren't alphanumerics,
    underscores, or hyphens. Convert to lowercase. Also strip leading and
    trailing whitespace, dashes, and underscores.
    """
    value = str(value)
    if allow_unicode:
        value = unicodedata.normalize('NFKC', value)
    else:
        value = unicodedata.normalize('NFKD', value).encode('ascii', 'ignore').decode('ascii')
    value = re.sub(r'[^\w\s-]', '', value.lower())
    return re.sub(r'[-\s]+', '-', value).strip('-_')


def generate_name(wlang, author, title):
    """Generates filename by author name and word's language"""
    return "data/modules/"+slugify(
        f"{wlang}_{author}_{title}_{str(datetime.timestamp(datetime.now())).replace('.', '')}.gsmf".lower().strip().replace(
            ' ', ''))


def write_init(module_file, author, title, wlang, cur_date, trfillmode, cover):
    """Writes init block to the study module file"""
    module_file.write("<gsmf>\n")
    module_file.write("  <init>\n")
    module_file.write(f"    <author>{author}</author>\n")
    module_file.write(f"    <title>{title}</title>\n")
    module_file.write(f"    <wlang>{wlang}</wlang>\n")
    module_file.write(f"    <date>{cur_date}</date>\n")
    module_file.write(f"    <trfillmode>{trfillmode}</trfillmode>\n")
    module_file.write(f"    <cover>{cover}</cover>\n")
    module_file.write(f" </init>\n")


def write_wordlist(module_file, word_list):
    """Writes list of words for learning"""
    module_file.write(" <wlist>\n")
    for word in word_list:
        module_file.write(f"    <word>{word}</word>\n")
    module_file.write(' </wlist>' + '\n')


def write_translations(module_file, source_language, word_list, translations=[], trlang=""):
    """Writes translations from source language to other supported ones"""
    module_file.write(" <translations>\n")
    if len(translations) and trlang in SUPPORTED_LANGUAGES and len(translations) == len(word_list):
        module_file.write(f"    <{trlang}>\n")
        for i in translations:
            module_file.write(f"        <tr>{i}</tr>\n")
        module_file.write(f"    </{trlang}>\n")

    for i in SUPPORTED_LANGUAGES:
        if i == source_language or i == trlang:
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
        module_file.write("     </wdblock>\n")
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
