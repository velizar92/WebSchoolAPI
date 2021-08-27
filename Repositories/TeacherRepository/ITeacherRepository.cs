using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories
{
    public interface ITeacherRepository
    {
        Task<IEnumerable<TeacherDto>> GetAll();
        Task<TeacherDto> Get(int id);
        Task<Teacher> Create(Teacher teacher);
        Task Update(Teacher teacher);
        Task Delete(int id);
    }
}
