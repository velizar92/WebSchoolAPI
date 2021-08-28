using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO.CourseDTOs;
using WebSchoolAPI.DTO.StudentsDTOs;

namespace WebSchoolAPI.DTO
{
    public class UniversityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }

        public ICollection<StudentNameDto> Students { get; set; }
        public ICollection<CourseNameDto> Courses { get; set; }
        public ICollection<TeacherNameDto> Teachers { get; set; }
    }
}
