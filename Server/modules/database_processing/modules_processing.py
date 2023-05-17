import modules.database_processing.database_modules
import base64
from datetime import date


def get_username_by_id(connection, author_id):
    """Returns author name  by his/her id"""
    cursor = connection.cursor()
    res = cursor.execute(f"SELECT name FROM Users WHERE id={author_id}").fetchall()
    try:
        return res[0][0]
    except:
        return None


def get_latest_modules(destination, page_num: int, page_size: int) -> []:
    offset = (page_num - 1) * page_size
    cursor = destination.cursor()
    cursor.execute('SELECT * FROM Studymodules ORDER BY id DESC LIMIT ? OFFSET ?', (page_size, offset))
    response_lines = cursor.fetchall()
    result_array = []
    for line in response_lines:
        current_module = {
            "id": line[0],
            "author": get_username_by_id(destination, line[1]),
            "title": line[2],
            "description": line[3],
            "icon": line[4],
            "language": line[5],
            "tags": line[6],
            "module_file": line[7],
            "created": line[9]
        }
        result_array.append(current_module)
    return result_array


def get_module_info(connection, module_id: int) -> dict:
    result = connection.cursor().execute(f"SELECT * FROM Studymodules WHERE id={module_id}").fetchall()
    if len(result) == 0:
        return {"status": 404, "description": "There is no module with such id!"}
    response_line = result[0]
    return {
        "status": 200,
        "id": response_line[0],
        "author": get_username_by_id(connection=connection, author_id=response_line[1]),
        "title": response_line[2],
        "description": response_line[3],
        "icon": response_line[4],
        "language": response_line[5],
        "tags": response_line[6],
        "module_file": response_line[7],
        "wordlist": response_line[8],
        "created": response_line[9]
    }


def add_module_to_database(connection, author_name, title, description, icon, language, tags, module_file, wordlist):
    """Appends the study module into the global database"""
    today = date.today().strftime('%Y-%m-%d')
    if modules.database_processing.database_modules.get_userid(connection, author_name) is None:
        return 0
    query = f'INSERT INTO Studymodules(authorId, title, description, iconPath, language, tags, moduleFile, wordlist, date) VALUES ' \
            f'({modules.database_processing.database_modules.get_userid(connection, author_name)}, "{title}", "{description}", "{icon}", "{language}", "{tags}", "{module_file}", "{wordlist}", "{today}");'
    connection.cursor().execute(query)
    connection.commit()


def download_module(connection, module_id: int) -> dict:
    query = f"SELECT moduleFile FROM Studymodules WHERE id={module_id}"
    result = connection.cursor().execute(query).fetchall()
    if len(result) == 0:
        return {"status": 404, "description": "module not found!", "data": ""}
    data = result[0][0]
    with open(data, "rb") as module_file:
        return {"status": 200, "data": str(base64.b64encode(module_file.read())).replace("b'", '').replace("'", '')}


def check_title(connection, title: str):
    query = f'SELECT * FROM Studymodules WHERE title="{title}"'
    result = connection.cursor().execute(query).fetchall()
    return len(result) != 0



def find_modules(connection, search_line: str):
    query_b_name = f"SELECT * FROM  Studymodules WHERE title LIKE '%{search_line}'"
    if not len(search_line.replace(" ", "")):
        return {"status": 200, "data": []}
    word_list = search_line.lower().split(" ")
    if len(word_list) == 1 and word_list[0] == ' ':
        word_list = [search_line]
    tags_query = "SELECT * FROM Studymodules WHERE "
    words_query = "SELECT * FROM Studymodules WHERE "
    for i, tag in enumerate(word_list):
        if i > 0:
            tags_query += " AND "
            words_query += " AND "
        tags_query += f"tags LIKE '%{tag}%'"
        words_query += f"wordList LIKE '%{tag}%'"
    c_cursor = connection.cursor()
    b_name = c_cursor.execute(query_b_name).fetchall()
    b_tags = c_cursor.execute(tags_query).fetchall()
    b_words = c_cursor.execute(words_query).fetchall()
    rows_got = b_name + b_tags + b_words
    result = []
    for line in rows_got:
        current_module = {
            "id": line[0],
            "author": get_username_by_id(connection, line[1]),
            "title": line[2],
            "description": line[3],
            "icon": line[4],
            "language": line[5],
            "tags": line[6],
            "module_file": line[7],
            "created": line[9]
        }
        if current_module not in result:
            result.append(current_module)
    return {"status": 200, "data": result}


