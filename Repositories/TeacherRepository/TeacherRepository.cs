using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories.TeacherRepository
{
    public class TeacherRepository : ITeacherRepository
    {
        public Task<Teacher> Create(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Teacher>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
