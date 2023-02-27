import secrets
import uvicorn
import os
from fastapi import FastAPI, Request
from modules.status_responses import *
from modules.requests_consts import *

app = FastAPI()
users = {}


@app.post("/register")
async def register_user(info: Request):
    """Processing of Registration Request"""
    req_info = await info.json()
    if req_info["action"] == REGISTER_REQUEST:
        if req_info["nickname"] not in users.keys() and req_info["action"] == "register" and len(req_info["password"]) != 0:
            user_nickname = req_info["nickname"]
            users[user_nickname] = str(secrets.token_hex(128))
            return build_successful_response()
        return build_unsucessfull_resuponse()




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
