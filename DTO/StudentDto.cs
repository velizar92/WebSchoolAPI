using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long EGN { get; set; }
        public long StudentNumber { get; set; }

        public string Univeristy { get; set; }
        public string CourseNames { get; set; }
    }
}
