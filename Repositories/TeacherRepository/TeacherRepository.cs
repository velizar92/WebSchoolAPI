using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories.TeacherRepository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolDbContext _context;
        private readonly IMapper _mapper;

        public TeacherRepository(SchoolDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public async Task<IEnumerable<TeacherDto>> GetAll()
        {
            return await _context.Teachers
                .ProjectTo<TeacherDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<TeacherDto> Get(int id)
        {
            return await _context.Teachers
                .ProjectTo<TeacherDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(s => s.Id == id);
        }


        public async Task Update(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
