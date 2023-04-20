def build_successful_response():
    """Returns data for success"""
    return build_simple_response(200, "successful")


def build_notfound_response():
    """Response for 404 error"""
    return build_simple_response(404, "Resource Wasn't Found!!")


def build_unsuccessful_response():
    return build_simple_response(404, "Unsuccessful")


def build_simple_response(code: int, message: str):
    return {
        "status": code,
        "description": f"{message}"
    }
