# ShipIt Inventory Management

## Setup Instructions
Open the project in VSCode.
VSCode should automatically set up and install everything you'll need apart from the database connection!

### Setting up the Database.
Create 2 new postgres databases - one for the main program and one for our test database.
Ask a team member for a dump of the production databases to create and populate your tables.

Then for each of the projects, add a `.env` file at the root of the project.
That file should contain a property named `POSTGRES_CONNECTION_STRING`.
It should look something like this:
```
POSTGRES_CONNECTION_STRING=Server=127.0.0.1;Port=5432;Database=your_database_name;User Id=your_database_user; Password=your_database_password;
```

## Running The API
Once set up, simply run dotnet run in the ShipIt directory.

## Running The Tests
To run the tests you should be able to run dotnet test in the ShipItTests directory.

## Deploying to Production
TODO

## Migrations
When you receive this code, please run the migrations in the Migrations folder using the following code:
```
psql -U [User name] -d postgresql://localhost:5432/[Database name] -f .\Migrations\001AddIndices.sql
psql -U [User name] -d postgresql://localhost:5432/[Database name] -f .\Migrations\002AddingPrimaryKeys.sql
```
This will ensure your database is up to date.
