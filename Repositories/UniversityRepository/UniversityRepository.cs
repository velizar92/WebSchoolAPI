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

        public async Task<IEnumerable<UniversityDto>> GetAll()
        {
            return await _context.Universities
                .Select(u => new UniversityDto()
                {
                    Id = u.Id,
                    Name = u.Name,
                    Description = u.Description,
                    Capacity = u.Capacity,
                    Courses = u.Courses.Select(c => c.Name).ToList(),

                    Students = u.Students.Select(s => new StudentNameDto()
                    {
                        FirstName = s.FirstName,
                        LastName = s.LastName
                    }).ToList(),

                    Teachers = u.Teachers.Select(t => new TeacherNameDto()
                    {
                        FirstName = t.FirstName,
                        LastName = t.LastName
                    }).ToList()
                })
                .ToListAsync();
        }

        public async Task<UniversityDto> Get(int id)
        {
            return await _context.Universities
                  .Select(u => new UniversityDto()
                  {
                      Id = u.Id,
                      Name = u.Name,
                      Description = u.Description,
                      Capacity = u.Capacity,
                      Courses = u.Courses.Select(c => c.Name).ToList(),

                      Students = u.Students.Select(s => new StudentNameDto()
                      {
                          FirstName = s.FirstName,
                          LastName = s.LastName
                      }).ToList(),

                      Teachers = u.Teachers.Select(t => new TeacherNameDto()
                      {
                          FirstName = t.FirstName,
                          LastName = t.LastName
                      }).ToList()
                  })
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(University university)
        {
            _context.Entry(university).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
