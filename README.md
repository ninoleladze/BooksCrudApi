# Books CRUD API

An **ASP.NET Core 8 Web API** for managing books, with EF Core, SQL Server, DTOs, a service layer and Swagger.

## Structure

- Controllers/BookController.cs — GET, POST, PUT /{bookId}, DELETE /{bookId}
- Services/Books/ — IBookServices + BookServices
- DTOs/ — CreateBookDto, UpdateBookDto
- Data/ + Migrations/ — EF Core

## Run

```bash
dotnet ef database update --project CRUDbooks
dotnet run --project CRUDbooks
```
