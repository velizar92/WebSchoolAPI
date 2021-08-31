using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO.AddressDTOs;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.AutomapperProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDto>();
           
        }
    }
}
