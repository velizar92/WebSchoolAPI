
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories.CourseRepository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolDbContext _context;

        public CourseRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task<Course> Create(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return course;
        }

        public async Task Delete(int id)
        {
            var courseToDelete = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(courseToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CourseDto>> GetAll()
        {
            return await _context.Courses
                .Select(s => new CourseDto()
                {
                    Id = s.Id,
                    Name = s.Name,                  
                    CourseNumber = s.CourseNumber,
                    Description = s.Description,
                    Students = string.Join(", ", s.Students),
                    Universities = string.Join(", ", s.Universities),
                    Teachers = string.Join(", ", s.Teachers)
                })
                .ToListAsync();
        }

        public async Task<CourseDto> Get(int id)
        {
            return await _context.Courses
                .Select(s => new CourseDto()
                {
                    Id = s.Id,
                    Name = s.Name,
                    CourseNumber = s.CourseNumber,
                    Description = s.Description,
                    Students = string.Join(", ", s.Students),
                    Universities = string.Join(", ", s.Universities),
                    Teachers = string.Join(", ", s.Teachers)
                })
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
