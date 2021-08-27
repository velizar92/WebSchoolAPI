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

        public async Task<IEnumerable<StudentDto>> GetAll()
        {
            return await _context.Students
                .Select(s => new StudentDto()
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Address = s.Address,
                    EGN = s.EGN,
                    StudentNumber = s.StudentNumber,                 
                    CourseNames = s.Courses.Select(c => c.Name).ToList(),
                    Univeristy = s.University.Name
                })
                .ToListAsync();
        }

        public async Task<StudentDto> Get(int id)
        {
            return await _context.Students
                 .Select(s => new StudentDto()
                 {
                     Id = s.Id,
                     FirstName = s.FirstName,
                     LastName = s.LastName,
                     Address = s.Address,
                     EGN = s.EGN,
                     StudentNumber = s.StudentNumber,                    
                     CourseNames = s.Courses.Select(c => c.Name).ToList(),
                     Univeristy = s.University.Name
                 })
                .FirstOrDefaultAsync(s => s.Id == id);
        }


        public async Task Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }




    }
}
