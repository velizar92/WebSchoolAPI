using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;
using WebSchoolAPI.Repositories;

namespace WebSchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeachersController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }


        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<Teacher>> GetTeachers()
        {
            return await _teacherRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int id)
        {
            return await _teacherRepository.Get(id);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<Course>> PostTeacher([FromBody] Teacher teacher)
        {
            var newTeacher = await _teacherRepository.Create(teacher);
            return CreatedAtAction(nameof(GetTeachers), new { id = teacher.Id }, newTeacher);
        }

        [HttpPut]
        [Route("update/{id}")]
        public async Task<ActionResult> PutTeacher(int id, [FromBody] Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return BadRequest();
            }

            await _teacherRepository.Update(teacher);
            return NoContent();
        }



        [HttpDelete("{id}")]
        [Route("delete/{id}")]
        public async Task<ActionResult> DeleteTeacher(int id)
        {
            var teacherToDelete = await _teacherRepository.Get(id);
            if (teacherToDelete == null)
            {
                return NotFound();
            }

            await _teacherRepository.Delete(teacherToDelete.Id);
            return NoContent();
        }
    }
}
