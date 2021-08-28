using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO.StudentsDTOs;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.AutomapperProfiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<Student, StudentNameDto>();
        }
    }
}
