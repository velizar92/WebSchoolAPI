using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _context;

        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }


        public async Task<Student> Create(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task Delete(int id)
        {
            var studentToDelete = await _context.Students.FindAsync(id);
            _context.Students.Remove(studentToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Students                       
                .ToListAsync();
   
        }

        public async Task<Student> Get(int id)
        {
            return await _context.Students
                .Include(s => s.Courses) 
                .Include(s => s.Teachers)
                .Include(s => s.University)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
