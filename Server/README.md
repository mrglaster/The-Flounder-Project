# Flunder Project: Server API 

## User-related requests


### Register

Routing: /user/register <br>
Type: POST


Example Request:

```
{
 	"nickname": "Glaster",
	"password": "thebestpassword",
	"email": "mymail@mail.ru",
	"avatar": "defaultAvatar.png", ; To use default one. You also can use base64 string here
	"secretkey": SECRET_KEY_NUMBER ; Secret Key. Now its type is Integer
}
```

Example Response:

```
{
	"status": 200,
	"description": "Welcome new user!"
}
```

If user with such auth data was already registered: 

```
{
	"status": 406,
	"description": "Unable to register user: such nickname or e-mail are already in user"
}
```


### Authorization

Routing: /user/login  <br>
Type: POST

Example Request:
```
{
  	"secretkey": SECRET_KEY, 
	"login": "TestLol1", 
	"password": "123",
}
```

Example Response: 

```
{
	"status": 200,
	"description": "You were successfully authorized"
}
```

If user's data is incorrect: 

```
{
	"status": 406,
	"description": "Wrong login or password"
}
```

## Modules-related requests

### Get latest modules

Routing: /study/latest_modules <br>
Type: GET

Example request:

```
{
	"secretkey": SECRET_KEY,
	"page": 1,
	"page_size": 5
}
```

Example Response: 

```
{
	"data": [
		{
			"id": 2,
			"author": "Glaster",
			"title": "Cold Weapon",
			"description": "This module lets you to study some cold weapons related vocabulary",
			"icon": "data/images/qr9TIlMziDK1QDVlJ9gU.png",
			"language": "en",
			"tags": "b1;weapon;cold weapon;sword;d&d",
			"module_file": "data/modules/en_glaster_coldweapon_168404827720493.gsmf",
			"created": "2023-05-14"
		},
		{
			"id": 1,
			"author": "Glaster",
			"title": "Vegetables (A1)",
			"description": "Simple module for A1 Students containing few vegatable topic related words",
			"icon": "data/images/default.png",
			"language": "en",
			"tags": "a1;easy;noob;classmates;vegetables;food",
			"module_file": "data/modules/en_glaster_vegetables(a1)_1684046824612142.gsmf",
			"created": "2023-05-14"
		}
	]
}
```

### Get information about the module

Routing: /study/get_module_info  <br>
Type: GET

Example request:

```
{
	"secretkey": SECRET_KEY,
	"module_id": 2
}
```

Example response: 

```
{
	"status": "success",
	"id": 2,
	"author": "Glaster",
	"title": "Cold Weapon",
	"description": "This module lets you to study some cold weapons related vocabulary",
	"icon": "data/images/qr9TIlMziDK1QDVlJ9gU.png",
	"language": "en",
	"tags": "b1;weapon;cold weapon;sword;d&d",
	"module_file": "data/modules/en_glaster_coldweapon_168404827720493.gsmf",
	"wordlist": "dagger;spear;sword;halberd;glaive;pole-axe;flail;mace;scythe;morningstar;greatsword",
	"created": "2023-05-14"
}
```

If module with such id doesn't exist:

```
{
	"status": 404,
	"description": "There is no module with such id!"
}
```


### Downlaod a module

Routing: /study/download_module  <br>
Type: GET

Example request:

```
{
	"secretkey": SECRET_KEY,
	"module_id": 2
}
```

Example Response:

```
{
	"status": 200,
	"data": "PGdzbW...dzbWY+"
```

If the module doesn't exist: 

```
{
	"status": 404,
	"description": "module not found!",
	"data": ""
}
```

### Create the module

Routing: /study/create_module  <br>
Type: POST

Example request:

```
{
	"secretkey": SECRET_KEY,
	"author": "Glaster",
	"title": "Vegetables (A1)",
	"description": "Simple module for A1 Students containing few vegatable topic related words",
	"language": "en",
	"wordlist": ["carrot", "parsley", "cabbage", "cucumber"],
	"tags": ["A1", "easy", "noob", "classmates", "vegetables", "food"],
	"translations": [],
  	"translations_language": "",
	"icon": "default"
}
```
Request if you want to use custom module icon: 

```
{
	"secretkey": SECRET_KEY,
	"author": "Glaster",
	"title": "Cold Weapon",
	"description": "This module lets you to study some cold weapons related vocabulary",
	"language": "en",
	"wordlist": ["Dagger", "Spear", "Sword", "Halberd", "Glaive", "Pole-Axe", "Flail", "Mace", "Scythe", "Morgenstern", "Greatsword"],
	"tags": ["B1", "weapon", "cold weapon", "sword", "D&D"],
	"translations": [],
	"translations_language": "",
	"icon": "iVBRw0KGg.....NJggg=="
}
```

Request if you want to use your own translations: 

```
{
	"secretkey": SECRET_KEY,
	"author": "Glaster",
	"title": "Firearms",
	"description": "Learn some new words about the guns!",
	"language": "en",
	"wordlist": ["Machinegun", "Rifle", "Shotgun", "Shell", "Bullet"],
	"tags": ["fun", "gun", "weapon", "firearms"],
	"translations": ["Пулемёт", "Винтовка", "Дробовик", "Гильза", "Пуля"],
	"translations_language": "ru",
	"icon": "default"
}

```


Example Response:

```
{
	"status": 200,
	"description": "The Module was Successfully created!",
	"module":  "PGdzbWY+...WY+"
}
```

If something is wrong with the user's data:

```
 {
    "status": 408,
    "description": "There is something wrong in your word list!",
    "module": ""
 }
```



