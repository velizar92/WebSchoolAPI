﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.DTO.AddressDTOs;
using WebSchoolAPI.DTO.CourseDTOs;
using WebSchoolAPI.DTO.UniversityDTOs;
using WebSchoolAPI.Models;

namespace WebSchoolAPI
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }       
        public long EGN { get; set; }
        public long StudentNumber { get; set; }


        public AddressDto Address { get; set; }
        public UniversityNameDto University { get; set; }
        public IEnumerable<CourseNameDto> Courses { get; set; }
    }
}
