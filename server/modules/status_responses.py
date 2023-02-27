def build_successful_response():
    return {
        "status": 200,
        "description": f"You were successfully registered!"
    }


def build_notfound_response():
    return {
        "status": 404,
        "description": f"Resource Wasn't Found!!"
    }


def build_unsucessfull_resuponse():
    return {
        "status": 404,
        "description": f"Unsuccessful!"
    }
