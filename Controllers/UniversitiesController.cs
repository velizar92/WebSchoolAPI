using Microsoft.AspNetCore.Authorization;
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
    public class UniversitiesController : ControllerBase
    {
        private readonly IUniversityRepository _universityRepository;

        public UniversitiesController(IUniversityRepository universityRepository)
        {
            _universityRepository = universityRepository;
        }


        [HttpGet]
        [Route("all")]
        [Authorize]
        public async Task<IEnumerable<UniversityDto>> GetUniversities()
        {
            return await _universityRepository.GetAll();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<UniversityDto>> GetUniversity(int id)
        {
            return await _universityRepository.Get(id);
        }

        [HttpPost]
        [Route("create")]
        [Authorize]
        public async Task<ActionResult<Course>> PostUniversity([FromBody] University university)
        {
            var newUniversity = await _universityRepository.Create(university);
            return CreatedAtAction(nameof(GetUniversities), new { id = university.Id }, newUniversity);
        }

        [HttpPut("{id}")]
        [Route("update/{id}")]
        [Authorize]
        public async Task<ActionResult> PutUniversity(int id, [FromBody] University university)
        {
            if (id != university.Id)
            {
                return BadRequest();
            }

            await _universityRepository.Update(university);
            return NoContent();
        }



        [HttpDelete("{id}")]
        [Route("delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteUniversity(int id)
        {
            var universityToDelete = await _universityRepository.Get(id);
            if (universityToDelete == null)
            {
                return NotFound();
            }

            await _universityRepository.Delete(universityToDelete.Id);
            return NoContent();
        }
    }
}
