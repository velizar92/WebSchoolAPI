using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.DTO.CourseDTOs;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.AutomapperProfiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDto>();
            CreateMap<Course, CourseNameDto>();
        }
    }
}
