using System.Collections.Generic;

namespace WebSchoolAPI.Models
{
    public class University
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }

        
        //Navigational properties:
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

        
    }
}
