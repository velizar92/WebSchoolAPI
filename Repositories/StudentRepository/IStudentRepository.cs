﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSchoolAPI.Models;

namespace WebSchoolAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<StudentDto>> GetAll();
        Task<StudentDto> Get(int id);
        Task<Student> Create(Student student);
        Task Update(Student student);
        Task Delete(int id);
    }
}
