import uvicorn
import os
import atexit
from fastapi import FastAPI, Request
from pyisemail import is_email
from modules.status_responses import *
from modules.database_modules import *

app = FastAPI()

DATABASE_PATH = "./Database/Glossa.db"
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
    if SECRET_KEY == req_info["secretkey"]:
        user_nickname = req_info["nickname"]
        user_email = req_info["email"]
        user_avatar = req_info["avatar"]
        user_password = req_info["password"]
        if is_user_registered(CONNECTION, user_nickname, user_email):
            return {
                "status": 406,
                "description": "Unable to register user: such nickname or e-mail are already in user",
            }
        sql = f'INSERT INTO Users(name, password, email, avatar) VALUES("{user_nickname}","{user_password}","{user_email}","{user_avatar}")'
        CONNECTION.cursor().execute(sql)
        CONNECTION.commit()
        return build_successful_response()
    return {"status": 407, "description": "Wrong Secret Key!"}


@app.post("/login")
@app.post("/authorize")
async def login_user(info: Request):
    req_info = await info.json()
    if req_info["secretkey"] == SECRET_KEY:
        user_login = req_info["login"]
        user_password = req_info["password"]
        login_type = is_email(user_login)
        if is_correct_authorize(CONNECTION, user_login, user_password, is_email=login_type):
            return {"status": 200, "description": "You were successfully authorized"}
        return {"status": 406, "description": "Wrong login or password"}
    return {"status": 407, "description": "Wrong secret key!"}


def on_exit():
    """Saves database on exit"""
    print("Saving Database...")
    CONNECTION.commit()
    print("Saved!")


def main():
    """Runs server via Uvicorn"""
    atexit.register(on_exit)
    uvicorn.run(f"{os.path.basename(__file__)[:-3]}:app", host="192.168.0.12", log_level="info")


if __name__ == "__main__":
    """Invokes the main function, starts the server"""
    main()


