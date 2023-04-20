import uvicorn
import os
import atexit
from fastapi import FastAPI, Request
from pyisemail import is_email

import modules.rr_processing.requests_consts
from modules.database_processing.database_modules import *

app = FastAPI()

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
            return modules.requests_consts.generate_access_denied_json(modules.requests_consts.USER_DATA_IN_USE_MESSAGE)
        sql = f'INSERT INTO Users(name, password, email, avatar) VALUES("{user_nickname}","{user_password}","{user_email}","{user_avatar}")'
        CONNECTION.cursor().execute(sql)
        CONNECTION.commit()
        return build_successful_response()
    return modules.requests_consts.WRONG_SKEY_JSON


@app.post("/user/login")
@app.post("/user/authorize")
async def login_user(info: Request):
    req_info = await info.json()
    if req_info["secretkey"] == SECRET_KEY:
        user_login = req_info["login"]
        user_password = req_info["password"]
        login_type = is_email(user_login)
        if is_correct_authorize(CONNECTION, user_login, user_password, is_email=login_type):
            return modules.requests_consts.generate_success_json(
                modules.requests_consts.AUTHORIZATION_SUCCESSFUL_MESSAGE)
        return modules.requests_consts.generate_access_denied_json(modules.requests_consts.WRONG_USERDATA_MESSAGERO)
    return modules.requests_consts.WRONG_SKEY_JSON


@app.post("/utils/errcodes")
@app.post("/utils/codes")
async def get_actual_err_codes(info: Request):
    req_info = await info.json()
    if req_info["secretkey"] == SECRET_KEY:
        print(modules.requests_consts.ACTUAL_CODES)
        return modules.requests_consts.ACTUAL_CODES
    return modules.requests_consts.WRONG_SKEY_JSON





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
