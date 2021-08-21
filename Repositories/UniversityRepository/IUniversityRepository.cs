using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories
{
    public interface IUniversityRepository
    {
        Task<IEnumerable<University>> GetAll();
        Task<University> Get(int id);
        Task<University> Create(University university);
        Task Update(University university);
        Task Delete(int id);
    }
}
