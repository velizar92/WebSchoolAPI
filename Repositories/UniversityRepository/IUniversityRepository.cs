using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories
{
    public interface IUniversityRepository
    {
        Task<IEnumerable<UniversityDto>> GetAll();
        Task<UniversityDto> Get(int id);
        Task<University> Create(University university);
        Task Update(University university);
        Task Delete(int id);
    }
}
