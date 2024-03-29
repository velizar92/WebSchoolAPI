﻿using System.Collections.Generic;

namespace WebSchoolAPI.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
            this.Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string Address { get; set; }
        public long EGN { get; set; }
        public long StudentNumber { get; set; }


        //Navigational properties:
        public Address Address { get; set; }
        public University University { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Teacher> Teachers { get; set; }


       


    }
}
