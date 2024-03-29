﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.DTO;
using WebSchoolAPI.Models;
using WebSchoolAPI.Repositories;

namespace WebSchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        [HttpGet]
        [Route("all")]
        [Authorize]
        public async Task<IEnumerable<CourseDto>> GetCourses()
        {
            return await _courseRepository.GetAll();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<CourseDto>> GetCourse(int id)
        {
            return await _courseRepository.Get(id);
        }

        [HttpPost]
        [Route("create")]
        [Authorize]
        public async Task<ActionResult<Course>> PostCourse([FromBody] Course course)
        {
            var newCourse = await _courseRepository.Create(course);
            return CreatedAtAction(nameof(GetCourses), new { id = course.Id }, newCourse);
        }

        [HttpPut("{id}")]
        [Route("update/{id}")]
        [Authorize]
        public async Task<ActionResult> PutCourse(int id, [FromBody] Course course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }

            await _courseRepository.Update(course);
            return NoContent();
        }



        [HttpDelete("{id}")]
        [Route("delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteCourse(int id)
        {
            var courseToDelete = await _courseRepository.Get(id);
            if (courseToDelete == null)
            {
                return NotFound();
            }

            await _courseRepository.Delete(courseToDelete.Id);
            return NoContent();
        }
    }
}
