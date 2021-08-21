using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories
{
    public interface ITeacherRepository
    {
        Task<IEnumerable<Teacher>> GetAll();
        Task<Teacher> Get(int id);
        Task<Teacher> Create(Teacher teacher);
        Task Update(Teacher teacher);
        Task Delete(int id);
    }
}
