using Demo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Contracts.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student Get(int id);
        int Create(Student student);
        void Delete(int id);
        int Edit(Student student);
    }
}
