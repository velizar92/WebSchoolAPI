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
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<StudentDto>> GetStudents()
        {
            return await _studentRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetStudent(int id)
        {
            return await _studentRepository.Get(id);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<Student>> PostStudent([FromBody] Student student)
        {
            var newStudent = await _studentRepository.Create(student);
            return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, newStudent);
        }

        [HttpPut]
        [Route("update/{id}")]
        public async Task<ActionResult> PutStudent(int id, [FromBody] Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            await _studentRepository.Update(student);
            return NoContent();
        }



        [HttpDelete("{id}")]
        [Route("delete/{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            var studentToDelete = await _studentRepository.Get(id);
            if (studentToDelete == null)
            {
                return NotFound();
            }

            await _studentRepository.Delete(studentToDelete.Id);
            return NoContent();
        }
    }
}
