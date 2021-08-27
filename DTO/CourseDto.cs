using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSchoolAPI.DTO
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CourseNumber { get; set; }


        public string Students { get; set; }
        public string Universities { get; set; }
        public string Teachers { get; set; }
    }
}
