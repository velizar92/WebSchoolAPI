using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.DTO.StudentsDTOs;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories.UniversityRepository
{
    public class UniversityRepository : IUniversityRepository
    {
        private readonly SchoolDbContext _context;
        private readonly IMapper _mapper;


        public UniversityRepository(SchoolDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<University> Create(University university)
        {
            _context.Universities.Add(university);
            await _context.SaveChangesAsync();

            return university;
        }

        public async Task Delete(int id)
        {
            var universityToDelete = await _context.Universities.FindAsync(id);
            _context.Universities.Remove(universityToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UniversityDto>> GetAll()
        {
            return await _context.Universities

                .ProjectTo<UniversityDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<UniversityDto> Get(int id)
        {
            return await _context.Universities
                .ProjectTo<UniversityDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(University university)
        {
            _context.Entry(university).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
