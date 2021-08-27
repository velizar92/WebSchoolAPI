using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories
{
    public interface ICourseRepository
    {
        Task<IEnumerable<CourseDto>> GetAll();
        Task<CourseDto> Get(int id);
        Task<Course> Create(Course course);
        Task Update(Course course);
        Task Delete(int id);
    }
}
