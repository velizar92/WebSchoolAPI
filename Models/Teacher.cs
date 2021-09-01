using System.Collections.Generic;

namespace WebSchoolAPI.Models
{
    public class Teacher
    {

        public Teacher()
        {
            this.Students = new HashSet<Student>();
            this.Courses = new HashSet<Course>();        
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }      
       // public string Address { get; set; }
        public long EGN { get; set; }


        //Navigational properties:
     
        public University University { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }

        
    }
}
