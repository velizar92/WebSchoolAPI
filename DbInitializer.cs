using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI
{
    public class DbInitializer
    {
        public static void Initialize(SchoolDbContext context)
        {
           
            if (context.Students.Any())
            {
                return;
            }

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //----------------------------------------------COURSES TEST DATA-------------------------------------------

            var cSharpFundamentals = new Course { Name = "C# Programming Fundamentals", Description = "Programming in C#" };
            var javaFundamentals = new Course { Name = "Java Programming Fundamentals", Description = "Programming in Java" };
            var jsFundamentals = new Course { Name = "JS Programming Fundamentals", Description = "Programming in JS" };
            var phpFundamentals = new Course { Name = "PHP Programming Fundamentals", Description = "Programming in PHP" };
            var pythonFundamentals = new Course { Name = "Python Programming Fundamentals", Description = "Programming in Python" };
            var kotlinFundamentals = new Course { Name = "Kotlin Programming Fundamentals", Description = "Programming in Kotlin" };

            var courses = new Course[] { cSharpFundamentals, javaFundamentals, jsFundamentals, phpFundamentals, pythonFundamentals, kotlinFundamentals };

            foreach (var course in courses)
            {
                context.Courses.Add(course);
            }

            //----------------------------------------------UNIVERSITIES/ACADEMIES/ TEST DATA-------------------------------------------

            var softUniAcademy = new University { Name = "Software University Academy", Capacity = 25000, Description = "This is SoftUni." };
            var softAcademy = new University { Name = "Soft Academy", Capacity = 18000, Description = "Sofia software academy." };
            var telericAcademy = new University { Name = "Teleric Academy", Capacity = 20000, Description = "Teleric academy." };

            var universities = new University[] { softUniAcademy, softAcademy, telericAcademy };

            foreach (var university in universities)
            {
                context.Universities.Add(university);
            }



            //-----------------------------------------------------TEACHERS TEST DATA---------------------------------------------------

            var teacherOne = new Teacher
                {
                    FirstName = "Petko",
                    LastName = "Dimitrov",                  
                    Address = "Bulgaria, V. Turnovo, Petko Karavelov str. 10",
                    EGN = 6511199876,
                };

            var teacherTwo = new Teacher
                {
                    FirstName = "Penka",
                    LastName = "Stoilova",
                    Address = "Bulgaria, Varna, Pancho Vladigerov str. 8",
                    EGN = 5811199876
                };

            var teacherThree = new Teacher
                {
                    FirstName = "Dimcho",
                    LastName = "Petkanov",
                    Address = "Bulgaria, Meden Rudnik, Maria Luiza str. 2",
                    EGN = 4511239876
                };

            var teacherFour = new Teacher
                {
                    FirstName = "Evstati",
                    LastName = "Cherkezov",
                    Address = "Bulgaria, Sofia, Georgi Rakovski str. 16",
                    EGN = 5111199876
                };

            var teacherFive =
                new Teacher
                {
                    FirstName = "Anastasia",
                    LastName = "Hvoinova",
                    Address = "Bulgaria, Pernik, Dimcho Debelyianov str. 10",
                    EGN = 7613199876
                };

            var teachers = new Teacher[] { teacherOne, teacherTwo, teacherThree, teacherFour, teacherFive };

            foreach (var teacher in teachers)
            {
                context.Teachers.Add(teacher);
            }

            //-----------------------------------------------------STUDENTS TEST DATA---------------------------------------------------

            var students = new Student[]
            {
                new Student {
                    FirstName = "Velizar",
                    LastName = "Georgiev",
                    Address = "Bulgaria, Sofia, Petko Karavelov str. 3",
                    EGN = 9102121783,
                    StudentNumber = 113623,
                    Courses = new List<Course> { cSharpFundamentals, kotlinFundamentals },
                    University = softUniAcademy,
                    Teachers = new List<Teacher> {teacherOne, teacherFour}
                },

                new Student {
                    FirstName = "Georgi",
                    LastName = "Boikov",
                    Address = "Bulgaria, Pleven, Vasil Levski str. 8",
                    EGN = 9812121800,
                    StudentNumber = 113777,
                    Courses = new List<Course> { javaFundamentals },
                    University = softUniAcademy,
                    Teachers = new List<Teacher> {teacherThree}
                },

                new Student {
                    FirstName = "Maria",
                    LastName = "Petkova",
                    Address = "Bulgaria, Pernik, Angel Kanchev str. 6",
                    EGN = 0102126719,
                    StudentNumber = 114626,
                    Courses = new List<Course> { pythonFundamentals },
                    University = softAcademy,
                    Teachers = new List<Teacher> {teacherOne}
                },

                new Student
                {
                    FirstName = "Dimitar",
                    LastName = "Elenkov",
                    Address = "Bulgaria, Sofia, Vasil Kaunchov str. 9",
                    EGN = 8407291783,
                      StudentNumber = 114632,
                    Courses = new List<Course> { cSharpFundamentals, phpFundamentals },
                    University = telericAcademy,
                    Teachers = new List<Teacher> {teacherFour, teacherTwo}
                },

                new Student
                {
                    FirstName = "Bojana",
                    LastName = "Dvorqnova",
                    Address = "Bulgaria, Burgas, Kiril i Metodii str. 2",
                    EGN = 8608176588,
                    StudentNumber = 120900,
                    Courses = new List<Course> { jsFundamentals },
                    University = telericAcademy,
                    Teachers = new List<Teacher> {teacherFour, teacherFive}
                },
            };


            foreach (var student in students)
            {
                context.Students.Add(student);
            }

        
            context.SaveChanges();

        }

    }
}
