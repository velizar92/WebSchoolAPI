﻿using System.Collections.Generic;

namespace WebSchoolAPI.Models
{
    public class Course
    {

        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
            this.Universities = new HashSet<University>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CourseNumber { get; set; }


        //Navigational properties:
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<University> Universities { get; set; }

        
    }
}
