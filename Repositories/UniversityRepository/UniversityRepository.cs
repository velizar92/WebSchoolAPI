using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories.UniversityRepository
{
    public class UniversityRepository : IUniversityRepository
    {
        public Task<University> Create(University university)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<University> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<University>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(University university)
        {
            throw new NotImplementedException();
        }
    }
}
