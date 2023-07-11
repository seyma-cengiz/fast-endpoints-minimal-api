# FastEndpoints Minimal Api

FastEndpoints is a developer friendly alternative to Minimal APIs & MVC. It nudges you towards the REPR Design Pattern (Request-Endpoint-Response) for convenient & maintainable endpoint creation with virtually no boilerplate. Performance is on par with Minimal APIs.

- **SendOkAsync():** Sends a 200 ok response without any body.

- **SendCreatedAtAsync():** Sends a 201 created response with a **_"Location"_** header containing where the resource can be retrieved from. See note about using with custom endpoint names.

- **SendNotFoundAsync():** Sends a 404 not found response.

For further info: https://fast-endpoints.com/docs/get-started