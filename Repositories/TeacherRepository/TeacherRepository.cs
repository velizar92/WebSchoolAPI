using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories.TeacherRepository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolDbContext _context;

        public TeacherRepository(SchoolDbContext context)
        {
            _context = context;
        }


        public async Task<Teacher> Create(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();

            return teacher;
        }

        public async Task Delete(int id)
        {
            var teacherToDelete = await _context.Teachers.FindAsync(id);
            _context.Teachers.Remove(teacherToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Teacher>> GetAll()
        {
            return await _context.Teachers.ToListAsync();
        }

        public async Task<Teacher> Get(int id)
        {
            return await _context.Teachers
                .Include(s => s.Students)
                .Include(s => s.Courses)
                .Include(s => s.University)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
