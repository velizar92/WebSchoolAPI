using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSchoolAPI.DTO
{
    public class UniversityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }

        public string Students { get; set; }
        public string Courses { get; set; }
        public string Teachers { get; set; }
    }
}
