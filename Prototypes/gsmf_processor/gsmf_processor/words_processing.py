import requests
import base64
from nostril import nonsense
from deep_translator import GoogleTranslator
from gsmf_processor.languages_parameters import GERMAN_GENUS
from pprint import pprint
from german_nouns.lookup import Nouns


def is_wordlist_valid(wordlist):
    """Checks if list of words doesn't contain nonsense"""
    return not nonsense(" ".join(wordlist))


def get_as_base64(url):
    """Returns file by link as base64 line"""
    return base64.b64encode(requests.get(url).content)


def translate_words(source_lang, dist_lang, words):
    """Translates a bunch of words to the selected language"""
    delimiter = '.'
    words_line = delimiter.join(words)
    translated = GoogleTranslator(source=f'{source_lang}', target=f'{dist_lang}').translate(text=words_line)
    if delimiter not in translated:
        results = translated.split(',')
    else:
        results = translated.split(delimiter)
    #if dist_lang == "de":
        #process_german_articles(results)
    return results


def process_german_articles(word_list):
    """Identifies nouns articles  for german"""
    nouns = Nouns()
    for i in range(len(word_list)):
        word = word_list[i]
        if word.startswith(" "):
            word = word[1:]
        if not word[0].isupper() or len(word.split(" ")) > 1:
            continue
        try:
            article = GERMAN_GENUS[nouns[word][0]["genus"]]
        except:
            article = '???'
        word_list[i] = article + ' ' + word_list[i]


def get_wordinfo_en(word):
    """Finds information about a word from English: definitions, pronunciation, examples when it's possible via Free Dictionary API"""
    request_link = 'https://api.dictionaryapi.dev/api/v2/entries/en/'
    response = requests.get(f"{request_link}{word}").json()
    try:
        pronunciation = get_as_base64(response[0]['phonetics'][0]['audio'])
    except:
        pronunciation = "NOT FOUND"
    definitions = []
    examples = []
    for i in response:
        if 'No Definitions Found' in i or type(i) is not dict:
            print(word)
            continue

        for z in i["meanings"]:
            for j in z["definitions"]:
                try:
                    definitions.append(j["definition"])
                    examples.append(j["example"])
                except:
                    pass

    if not len(examples):
        examples.append("We're sorry, but we hadn't found any examples for this word(((((")
    if not len(definitions):
        definitions.append("We're sorry, but we hadn't found any definitions for this word(((")
    return pronunciation, definitions, examples
