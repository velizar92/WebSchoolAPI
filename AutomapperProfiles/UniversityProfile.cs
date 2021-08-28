﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.AutomapperProfiles
{
    public class UniversityProfile : Profile
    {
        public UniversityProfile()
        {
            CreateMap<University, UniversityDto>();        
        }
    }
}
