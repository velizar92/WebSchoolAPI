using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories.UniversityRepository
{
    public class UniversityRepository : IUniversityRepository
    {
        private readonly SchoolDbContext _context;

        public UniversityRepository(SchoolDbContext context)
        {
            _context = context;
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

        public async Task<IEnumerable<University>> GetAll()
        {
            return await _context.Universities.ToListAsync();
        }

        public async Task<University> Get(int id)
        {
            return await _context.Universities
                .Include(s => s.Students)
                .Include(s => s.Courses)
                .Include(s => s.Teachers)    
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(University university)
        {
            _context.Entry(university).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
