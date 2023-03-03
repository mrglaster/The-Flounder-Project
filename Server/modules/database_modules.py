import sqlite3 as sl


def get_rowcount(connection, tablename):
    """Gets amount of rows in the table."""
    try:
        cursor = connection.cursor()
        cursor.execute(f"select * from {tablename}")
        results = cursor.fetchall()
        return len(results)
    except:
        raise ValueError(f"Error occured during getting data from table {tablename}. Check if tablename is valid")


def get_newestId(connection, tablename):
    """gets id can be used for adding data"""
    return get_rowcount(connection, tablename) + 1


def create_connection(db_file):
    """ create a database connection to the SQLite database
        specified by the db_file
    :param db_file: database file
    :return: Connection object or None
    """
    return sl.connect(db_file)


def delete_row_bId(connection, table_name, row, idname='id'):
    """Deletes row in some table by row's id"""
    sql_request = f'DELETE FROM {table_name} WHERE id={row}'
    cur = connection.cursor()
    cur.execute(sql_request)
    connection.commit()


def clear_table(connection, table_name):
    """Clears the whole table!"""
    sql_request = f'DELETE FROM {table_name}'
    cur = connection.cursor()
    cur.execute(sql_request)
    connection.commit()


def get_table_column(connection, table_name, column_name):
    """Returns all values from column of some table"""
    cursor = connection.cursor()
    cursor.execute(f"SELECT {column_name} FROM {table_name}")
    return cursor.fetchall()


def is_value_used(connection, table_name, column_name, value):
    """Checks if input value was already used in some column"""
    all_columns = get_table_column(connection, table_name, column_name)
    for i in all_columns:
        column_value = str(i).replace('(', '').replace(')', '').replace("'", '').replace(',', '')
        if column_value == value:
            return True
    return False


def is_user_registered(connection, name, email):
    query = f'SELECT COUNT(id) FROM (SELECT * FROM Users where name="{name}" or email="{email}") ;'
    cursor = connection.cursor()
    return cursor.execute(query).fetchall()[0][0] != 0
