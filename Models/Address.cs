using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSchoolAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        
     
        public Student Student { get; set; }    
        public Teacher Teacher { get; set; }     
        public University University { get; set; }

    }
}
