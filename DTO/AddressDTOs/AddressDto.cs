using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSchoolAPI.DTO.AddressDTOs
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
    }
}
