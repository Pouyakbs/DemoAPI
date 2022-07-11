using Demo.Core.Domain.DTOs;
using Demo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Contracts.Facade
{
    public interface IStudentFacade
    {
        IEnumerable<StudentDTO> GetAll();
        StudentDTO Get(int id);
        int Create(StudentDTO student);
        void Delete(int id);
        int Edit(StudentDTO student);
    }
}
