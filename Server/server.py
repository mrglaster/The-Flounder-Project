import secrets
import uvicorn
import os
import sqlite3 as sl
from fastapi import FastAPI, Request
from modules.status_responses import *
from modules.requests_consts import *
from modules.database_modules import *

app = FastAPI()


DATABASE_PATH = './Database/Glossa.db'
CONNECTION = create_connection(DATABASE_PATH)
SECRET_KEY = 42


@app.post("/register")
async def register_user(info: Request):
    """Function Processing Register Request
            main parameters:
                :param nickname - login of the user
                :param email - e-mail of user
                :param password - password of the user
    """
    req_info = await info.json()
    if SECRET_KEY == 42:
        user_nickname = req_info["nickname"]
        user_email = req_info["email"]
        user_avatar = req_info["avatar"]
        user_password = req_info["password"]
        if is_user_registered(CONNECTION, user_nickname, user_email):
            return {"status": 406, "description": "Unable to register user: such nickname or e-mail are already in user"}
        sql = f'INSERT INTO Users(name, password, email, avatar) VALUES("{user_nickname}","{user_password}","{user_email}","{user_avatar}")'
        CONNECTION.cursor().execute(sql)
        return build_successful_response()
    return {"status": 407, "description": "Wrong Secret Key!"}






@app.post("/login")
async def login_user(info: Request):
    req_info = await info.json()
    if req_info["action"] == LOGIN_REQUEST:
        return build_unsucessfull_resuponse()


def main():
    """Runs server via Uvicorn"""
    uvicorn.run(f"{os.path.basename(__file__)[:-3]}:app", log_level="info")


if __name__ == "__main__":
    """Invokes the main function, starts the server"""
    main()
