import json

"""

In this module we provide constants for responses,
such for status codes as for field names

"""

# Error Codes
SUCCESS_CODE = 200
ACCESS_DENIED_CODE = 406
BAD_SECRET_KEY_CODE = 407
BAD_WORDKIT_CODE = 408

# Error Names
SUCCESS_NAME = "success"
ACCESS_DENIED_NAME = "accessDenied"
BAD_SECRET_KEY_NAME = "badSecretKey"
BAD_WORDKIT_NAME = "badWordkit"

# Text Description Storage
USER_DATA_IN_USE_MESSAGE = "Unable to register user: such nickname or e-mail are already in user"
AUTHORIZATION_SUCCESSFUL_MESSAGE = "You were successfully authorized"
WRONG_SKEY_MESSAGE = "Wrong Secret Key"
WRONG_USERDATA_MESSAGE = "Wrong login or password"

# JSONs
ACTUAL_CODES = {
    "status": 200,
    f"{SUCCESS_NAME}": SUCCESS_CODE,
    f"{ACCESS_DENIED_NAME}": ACCESS_DENIED_CODE,
    f"{BAD_SECRET_KEY_NAME}": BAD_SECRET_KEY_CODE,
    f"{BAD_WORDKIT_NAME}": BAD_WORDKIT_CODE
}

WRONG_SKEY_JSON = {"status": ACCESS_DENIED_CODE, "description": WRONG_SKEY_MESSAGE}


# JSON-generating functions
def generate_success_json(description: str):
    """Generate successful-status json with custom description """
    return {"status": SUCCESS_CODE, "description": description}


def generate_access_denied_json(reason: str):
    """Generates response for 'Access-Denied-Case """
    return {"status": ACCESS_DENIED_CODE, "description": reason}
