using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO.StudentsDTOs;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.DTO
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CourseNumber { get; set; }


        public ICollection<StudentNameDto> Students { get; set; }
        public ICollection<string> Universities { get; set; }
        public ICollection<TeacherNameDto> Teachers { get; set; }
    }
}
