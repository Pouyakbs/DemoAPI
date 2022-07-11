using Demo.Core.Contracts.Repository;
using Demo.Core.Domain.Entities;
using Demo.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Infrastructure.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DemoContext context;
        public StudentRepository(DemoContext context)
        {
            this.context = context;
        }
        public Student Get(int id)
        {
            return context.Students.Find(id);
        }
        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }
        public int Create(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student.StudentId;
        }
        public void Delete(int id)
        {
            context.Students.Remove(new Student() { StudentId = id });
            context.SaveChanges();
        }
        public int Edit(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
            return student.StudentId;
        }
    }
}
