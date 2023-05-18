CREATE TABLE IF NOT EXISTS Users(
	id INTEGER PRIMARY KEY AUTOINCREMENT,
  	name TEXT not NULL,
  	password TEXT NOT NULL,
    email TEXT NOT NULL,
    ispro BIT DEFAULT 1,
    proType TEXT DEFAULT "start",
  	proStarts DATETIME DEFAULT CURRENT_TIMESTAMP,
    avatar TEXT DEFAULT "data/images/default_avatar.png"
);

CREATE TABLE IF NOT EXISTS Studymodules(
	id INTEGER PRIMARY KEY AUTOINCREMENT, 
	authorId INTEGER NOT NULL,
    title TEXT NOT NULL,
    description TEXT,
    iconPath TEXT DEFAULT "data/images/default_cover.png",
    language VARCHAR(2) NOT NULL,
	tags TEXT,
    moduleFile TEXT NOT NULL,
	wordList TEXT NOT NULL,
	date DATE NOT NULL
);

CREATE TABLE IF NOT EXISTS history(
	id INTEGER PRIMARY KEY AUTOINCREMENT,
    moduleId INTEGER NOT NULL,
    userId INTEGER NOT NULL,
    uaction BIT NOT NULL 
);

