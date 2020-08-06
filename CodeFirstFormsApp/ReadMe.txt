Notes for future reference.

What is this project?
This creates a form utilizing Entity Framework Code First approach. 
The form has basic CRUD functionality and the database is interacted with using LINQ.

Generating Database
1. Open Package Manager Console.
2. Type "Enable-Migrations". Sets up Entity Framework migrations. Creates Configuration class in new migrations folder.
3. Type "Add-Migration Initial". Creates migration based on the models we have.
4. Type "Update-Database". Entity Framework creates the database.

Updating Models
1. Open Package Manager Console.
2. Type "Add-Migration 'Relevant Name'". EF scans project for new info and creates new migration.
3. Type "Update-Database". EF applies migrations.