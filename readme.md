# CQRS demo
- Provides a template that can be used for developing and supporting a backend both for medium and large projects.
- The approach includes the usage of MediatR, FluentValidation, ApiVersion control, and other libraries to build and handle a request pipeline. 
- According to such segregation, new business logic can be added easily in terms of domain models, validation rules, commands, and queries.

## Build
- Navigate to `Taskly.WebApi` directory and run `dotnet build` and `dotnet run`.
- You also can specify `appsettings.json` and set the following attributes:
  - `DbConnection` - the project uses SQLite DB. DB will be created automatically.
  - `Logger:Directory` - path to the log folder.

 ## Uasge
Using SwaggerUI or Postman and perform the following steps:
 - Invoke `/api/v1/auth/register` and pass `Name`, `Password` and `Email` to register a new user.
 - Use `/api/v1/auth/token` to get the user token.
 - Pass the token to the `/api/v1/Note` requests in `Authentication` attribute in header of requests. For instance, `"Authentication": "Bearer %your-token%"`