# Minimal API utilizando Flunt

Esse projeto buscou utilizar funcionalidades do Flunt e entender um pouco do funcionamento das Minimal API's que corroboram para a criação de microsserviços API. 

Veja a seguir uma BadRequest em formato Json:

```json
{
  "message": "Invalid request",
  "notifications": [
    {
      "key": "Name.Value",
      "message": "The name is invalid"
    },
    {
      "key": "Name.Value",
      "message": "The name is invalid"
    },
    {
      "key": "Name.Value",
      "message": "The name is invalid"
    }
  ],
  "isValid": false
}
```

Veja a seguir uma 200 Request em formato Json:

```json
{
  "message": "Registry name created",
  "notifications": [],
  "isValid": true
}
```