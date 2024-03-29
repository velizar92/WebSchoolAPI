﻿
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

namespace WebSchoolAPI.Repositories.CourseRepository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolDbContext _context;
        private readonly IMapper _mapper;

        public CourseRepository(SchoolDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
                .ProjectTo<CourseDto>(_mapper.ConfigurationProvider)             
                .ToListAsync();
        }


        public async Task<CourseDto> Get(int id)
        {
            return await _context.Courses
                .ProjectTo<CourseDto>(_mapper.ConfigurationProvider)           
                .FirstOrDefaultAsync(s => s.Id == id);
        }


        public async Task Update(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
