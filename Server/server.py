import uvicorn
import os
import atexit
from fastapi import FastAPI, Request
from pyisemail import is_email
from fastapi.staticfiles import StaticFiles
import modules.rr_processing.requests_consts
import modules.pronunciation.pronunciation
from modules.database_processing.database_modules import *
from modules.database_processing.modules_processing import get_latest_modules
from modules.gsmf_processing.writer import create_module

app = FastAPI()
app.mount("/data", StaticFiles(directory="data"), name="data")
DATABASE_PATH = "./Database/Glossa.db"
CONNECTION = create_connection(DATABASE_PATH)
SECRET_KEY = 42


@app.post("/user/register")
async def register_user(info: Request):
    """Function Processing Register Request
    main parameters:
        :param nickname - login of the user
        :param email - e-mail of user
        :param password - password of the user
    """
    req_info = await info.json()
    if SECRET_KEY == req_info["secretkey"]:
        user_nickname = req_info["nickname"]
        user_email = req_info["email"]
        user_avatar = req_info["avatar"]
        user_password = req_info["password"]
        if is_user_registered(CONNECTION, user_nickname, user_email):
            return modules.rr_processing.requests_consts.generate_access_denied_json(
                modules.rr_processing.requests_consts.USER_DATA_IN_USE_MESSAGE)
        sql = f'INSERT INTO Users(name, password, email, avatar) VALUES("{user_nickname}","{user_password}","{user_email}","{user_avatar}")'
        CONNECTION.cursor().execute(sql)
        CONNECTION.commit()
        return modules.rr_processing.requests_consts.generate_success_json("Welcome new user!")
    return modules.rr_processing.requests_consts.WRONG_SKEY_JSON


@app.post("/user/login")
@app.post("/user/authorize")
async def login_user(info: Request):
    req_info = await info.json()
    if req_info["secretkey"] == SECRET_KEY:
        user_login = req_info["login"]
        user_password = req_info["password"]
        login_type = is_email(user_login)
        if is_correct_authorize(CONNECTION, user_login, user_password, is_email=login_type):
            return modules.rr_processing.requests_consts.generate_success_json(
                modules.rr_processing.requests_consts.AUTHORIZATION_SUCCESSFUL_MESSAGE)
        return modules.rr_processing.requests_consts.generate_access_denied_json(
            modules.rr_processing.requests_consts.WRONG_USERDATA_MESSAGE)
    return modules.rr_processing.requests_consts.WRONG_SKEY_JSON


@app.post("/utils/errcodes")
@app.post("/utils/codes")
async def get_actual_err_codes(info: Request):
    req_info = await info.json()
    if req_info["secretkey"] == SECRET_KEY:
        print(modules.rr_processing.requests_consts.ACTUAL_CODES)
        return modules.rr_processing.requests_consts.ACTUAL_CODES
    return modules.rr_processing.requests_consts.WRONG_SKEY_JSON


@app.post("/study/latest_modules")
async def get_l_modules(info: Request):
    print(info)
    req_info = await  info.json()
    if req_info["secretkey"] == SECRET_KEY:
        page = req_info["page"]
        page_size = req_info["page_size"]
        return {"status": 200, "data": get_latest_modules(destination=CONNECTION, page_num=page, page_size=page_size)}
    return modules.rr_processing.requests_consts.WRONG_SKEY_JSON


@app.get("/study/get_module_info")
async def get_info_module(info: Request):
    req_info = await  info.json()
    if req_info["secretkey"] == SECRET_KEY:
        module_id = req_info["module_id"]
        if module_id <= 0 or module_id is None:
            return {"status": 404, "description": "There is no module with such id! ID start from 1!"}
        return modules.database_processing.modules_processing.get_module_info(connection=CONNECTION,
                                                                              module_id=module_id)
    return modules.rr_processing.requests_consts.WRONG_SKEY_JSON


@app.post("/study/create_module")
async def generate_module(info: Request):
    req_info = await info.json()
    return create_module(connection=CONNECTION, request_json=req_info)


@app.get("/study/download_module")
async def send_module(info: Request):
    req_info = await info.json()
    if req_info["secretkey"] == SECRET_KEY:
        return modules.database_processing.modules_processing.download_module(connection=CONNECTION,
                                                                              module_id=req_info["module_id"])


@app.post("/study/pronunciation")
async def analyze_pronunciation(info: Request):
    req_info = await info.json()
    if req_info["secretkey"] == SECRET_KEY:
        audio = req_info["audio"]
        a_format = req_info["format"]
        word = req_info["word"]
        return modules.pronunciation.pronunciation.check_pronunciation_english_only(audio_base64=audio, word=word,
                                                                                    a_format=a_format)
    return modules.rr_processing.requests_consts.WRONG_SKEY_JSON


def on_exit():
    """Saves database on exit"""
    print("Saving Database...")
    CONNECTION.commit()
    print("Saved!")


def main():
    """Runs server via Uvicorn"""
    atexit.register(on_exit)
    uvicorn.run(f"{os.path.basename(__file__)[:-3]}:app", log_level="info")


if __name__ == "__main__":
    """Invokes the main function, starts the server"""
    main()
