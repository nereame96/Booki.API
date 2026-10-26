# Booki API

A REST API to keep track of the books you read. Each user can manage their own personal library: add books, link them to authors, set a reading status, rate them and keep notes.

## Features

- Manage users, authors and books
- Track the reading status of each book (e.g. *To read*, *Reading*, *Read*)
- Rate books from 1 to 5 and add short notes
- Record start and finish dates
- Classify books by genre

## Tech stack

- C# / ASP.NET Core Web API
- Entity Framework Core (Code First)
- SQL Server

## Getting started

1. Clone the repository:
   ```bash
   git clone https://github.com/nereame96/Booki.API.git
   ```
2. Update the connection string in `appsettings.json` to point to your SQL Server instance.
3. Apply the migrations:
   ```bash
   dotnet ef database update
   ```
4. Run the project:
   ```bash
   dotnet run
   ```

## Status

Work in progress. Endpoints and documentation will be added soon.