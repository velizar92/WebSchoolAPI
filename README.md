![DataModel](https://user-images.githubusercontent.com/40525254/132227872-8e4f08b7-95ba-408f-9be9-f7bfbadf769c.png)
# WebSchoolAPI

#Overview#:
The project is inspired by the self learning of EF Core and ASP.NET Core Web Api technologies. Every new knowledge that I received, I tried to implement it inside the project.
The project itself is a Web Api written on ASP.NET Core technology and for ORM is used EF Core v.5. There are presented some entities/models which have their own tables in the MS SQL server. These entities/tables are connected by foreigh keys. 
In the project are implemented "One to Many", "Many to Many" and "One to One" relationships. It is used Database.EnsureCreated() method, but not migrations. 

Included project characteristics:

1. Models for: Student, University, Teacher and Course
2. Working with EF Core v.5 for creating of database from the particular models (from classes) -> Code First aproach
3. Working with Repository layer. There are created repositories for every model, and these repositories are used in the controllers as a services that make the queries to the database.
4. Working with DTOs (Data Transfer Objects)
5. Working with "Automapper" library for mapping of Model classes to DTOs
6. CRUD operations in the controllers (used repository layer)
7. Possible tests of the API with Postman /see documentation below/
8. Users configurations -> Register/Login (+ Registration of Admin user)
9. Authentication is based on JWT token

NОТЕ: The project is made like an exercise of all learned new things for a specific time period. My goal was to practice everything that i learned for this time interval.
    
  Used Software:
  
  1. IDE - Visual Studio 2019 v.16.9.3
  2. ORM - Entity Framework Core v.5.0
  3. Web Framework - ASP.NET Core 5.0
  4. MSSQL Server Express 2019
  5. Automapper v.10.1.1 /library installed from Nuget/ 
  6. Jwtbearer package /for authentication of users/


    
    
    
