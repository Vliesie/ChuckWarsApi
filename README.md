
# Chuckwars API

An API that Abstractly Downstreams two Other APIs:

Namely:

- https://swapi.dev

- https://api.chucknorris.io

## Front End SPA:
https://chuckwarsfront.herokuapp.com/


API Interface & info:
https://chuckwarsapi.herokuapp.com/swagger/index.html

Notes:
Advanced Security is not present due to complications with Heroku Hosting. Plans were to Implement OAuth with Automatic Key Generating with user credentials using a Endpoint /user/auth Heroku Hosting has complicated this process. Potential future update.

List of Chuck Norris Category Names:

- animal 
- career
- celebrity
- dev
- expcit
- fashion
- food
- history
- money
- movie
- music
- potical
- region
- science
- sport
- travel

## API Reference

#### Get all Categories

```http
  GET /Chuck/categories
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `api_key` | `string` | **Required** -  pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp |



#### Get Random Joke

```http
  GET /Chuck/randomjoke
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `api_key` | `string` | **Required** -  pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp |
| `query` | `string` | **Required** -  Chuck Norris Category Name |

#### Search SwAPI & ChuckAPI

```http
  GET /search
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `api_key` | `string` | **Required** -  pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp |
| `query` | `string` | **Required** -  Star Wars Person Name or Chuck Norris Category |





#### Get All People

```http
  GET /Swapi/People
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `api_key` | `string` | **Required** -  pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp |



