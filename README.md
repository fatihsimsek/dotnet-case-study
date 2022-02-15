# Dotnet AspNet Core Study Case

Vehicle APIs (AspNet Core / Jwt / Swagger)

### Create Token

#### Request

`POST /api/auth/authenticate`

    {
        "email": "fatih.simsek@outlook.com",
        "password":"12345"
    }

#### Response
    {
        "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6Ijg5YWNmZWRkLTA4OWEtNDEyNy05ZTFiLWJlNWRlZGQwZWY2NSIsInVuaXF1ZV9uYW1lIjoiZmF0aWguc2ltc2VrQG91dGxvb2suY29tIiwiZW1haWwiOiJmYXRpaC5zaW1zZWtAb3V0bG9vay5jb20iLCJuYmYiOjE2NDQ4MzIxNzIsImV4cCI6MTY0NDgzMjc3MiwiaWF0IjoxNjQ0ODMyMTcyfQ.C-wycLWdfnVyQbSOvT-wOi-isdGF0PkF0E3crqhrlu8"
    }
