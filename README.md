# response-api
Simple API that returns responses for the purpose of a demo

## POST
```
Content-Type: application/json
{
    "expectedReturnedCode": string
}
```

To curl:

`curl -d '{"expectedReturnedCode":"200"}' -H "Content-Type: application/json" -X POST http://localhost:5000/api/values`


- _"expectedReturnedCode":"200"_ : Will return a 200OK with the message " Winner, winner, chicken dinner"

- _"expectedReturnedCode":"404"_ : Will return a 404NotFound with the message " Still haven't found what you're looking for"

- _"expectedReturnedCode":"500"_ : Will return a 500InternalServerError with the message " Internal Server Error"

- _"expectedReturnedCode":**any other value**_ : Will return a 400BadRequest with the message "  You haven't provided a recognised ExpectedReturnedCode"
