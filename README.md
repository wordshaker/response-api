# Response API
Simple API that returns responses for the purpose of a demo

## POST
```
Content-Type: application/json
{
    "expectedReturnedCode": string
}
```

Curl request example

`curl -i -d '{"expectedReturnedCode":"200"}' -H "Content-Type: application/json" -X POST http://localhost:5000/api/code`