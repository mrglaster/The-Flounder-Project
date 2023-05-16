import requests

SERVICE_URL = "https://pronunciation-assessment1.p.rapidapi.com/pronunciation"


def check_pronunciation_english_only(audio_base64: str, word: str, a_format: str) -> dict:
    payload = {
        "audio_base64": f"{audio_base64}",
        "audio_format": f"{a_format}",
        "text": f"{word}"
    }

    headers = {
        "content-type": "application/json",
        "X-RapidAPI-Key": "fc0375a11fmsh92b1219e5849c87p17ddc4jsn8bc03c3f1c4e",
        "X-RapidAPI-Host": "pronunciation-assessment1.p.rapidapi.com"
    }
    try:
        response = requests.post(SERVICE_URL, json=payload, headers=headers).json()
        scores = response["score_estimates"]["ielts"]
        return {"status": 200, "scores": scores}
    except:
        return {"status": 406, "description": "something went wrong"}
