# WebSchoolAPI

#Overview#:
The project is inspired by the self learning of EF Core and ASP.NET Core Web Api technologies. Every new knowledge that I received, I tried to implement it inside the project.
The project itself is a Web Api written on ASP.NET Core technology and for ORM is used EF Core v.5. There are presented some entities/models which have their own tables in the MS SQL server. These entities/tables are connected by foreigh keys. 
In the project are implemented "One to Many" and "Many to Many" relationships. It is used Database.EnsureCreated() method, but not migrations. 

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

API Documentation:

  0. Registration/Login:

    
    - Registration /user/
     
    https://localhost:{port-number}/api/authenticate/register
    
    - Registration /user-admin/
     
    https://localhost:{port-number}/api/authenticate/register-admin
    
    Registration format: 
    
    {
      "username": "peter123",
      "email" : "peter@gmail.com",
      "password": "Peter12345@"
    }
    
    - Login
     
    https://localhost:{port-number}/api/authenticate/login
    
    Login format:
    
    {
      "username": "peter123",   
      "password": "Peter12345@"
    }
   

 1.REST Endpoints:
 
  1.1 Students
  
    https://localhost:{port-number}/api/students/all                      -> get all students
    
    https://localhost:{port-number}/api/students/{id}                     -> get student by id
    
    https://localhost:{port-number}/api/students/create                   -> create student
    
    https://localhost:{port-number}/api/students/update/{id}                   -> update student
    
    https://localhost:{port-number}/api/students/delete/{id}                   -> delete student  /only admin/
    
    Create student /format/:
    
    {
      "firstname": "peter",
      "lastname":  "petrov",
      "address":  "Bulgaria, Sofia, Mladost 3",
      "egn": 9610151808,
      "studentNumber": 113790
    }
    
  1.2 Courses
  
    https://localhost:{port-number}/api/courses/all                       -> get all courses
    
    https://localhost:{port-number}/api/courses/{id}                      -> get course by id
    
    https://localhost:{port-number}/api/courses/create                    -> create course
    
    https://localhost:{port-number}/api/courses/update/{id}                    -> update course
    
    https://localhost:{port-number}/api/courses/delete/{id}                    -> update course   /only admin/
    
    Create course /format/:    
    
      {
        "name": "C# Programming Basics",
        "description":  "It's about programming dude! ",
        "courseNumber":  1133
      }
    
  1.3 Teachers
  
    https://localhost:{port-number}/api/teachers/all                           -> get all teachers
    
    https://localhost:{port-number}/api/teachers/{id}                          -> get teacher by id
    
    https://localhost:{port-number}/api/teachers/create                        -> create teacher
    
    https://localhost:{port-number}/api/teachers/update/{id}                   -> update teacher
    
    https://localhost:{port-number}/api/teachers/delete/{id}                   -> delete teacher  /only admin/
    
    Create teacher /format/:
    
      {
        "firstname": "mihail",
        "lastname":  "dimitrov",
        "address":  "Bulgaria, Sofia, Lyulin 6",
        "egn": 9010151808,   
      }
    
  1.4 Universities
  
    https://localhost:{port-number}/api/universities/all                       -> get all universities
    
    https://localhost:{port-number}/api/universities/{id}                      -> get university by id
    
    https://localhost:{port-number}/api/universities/create                    -> create university
    
    https://localhost:{port-number}/api/universities/update/{id}               -> update university
    
    https://localhost:{port-number}/api/universities/delete/{id}               -> delete university /only admin/
    
     Create university /format/:
     
      {
        "name": "Kliment Ohridski",
        "capacity":  "20000",
        "description":  "Technical profile"
      }
    
  Used Software:
  
  1. IDE - Visual Studio 2019 v.16.9.3
  2. ORM - Entity Framework Core v.5.0
  3. Web Framework - ASP.NET Core 5.0
  4. MSSQL Server Express 2019
  5. Automapper v.10.1.1 /library installed from Nuget/ 
  6. Jwtbearer package /for authentication of users/


    
    
    
