using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO.CourseDTOs;
using WebSchoolAPI.DTO.UniversityDTOs;

namespace WebSchoolAPI.DTO
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long EGN { get; set; }

        public UniversityNameDto University { get; set; }
        public IEnumerable<CourseNameDto> Courses { get; set; }

      
    }
}
