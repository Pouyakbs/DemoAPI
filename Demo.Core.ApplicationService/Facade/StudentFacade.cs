using AutoMapper;
using Demo.Core.Contracts.Facade;
using Demo.Core.Contracts.Repository;
using Demo.Core.Domain.DTOs;
using Demo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.ApplicationService.Facade
{
    public class StudentFacade : IStudentFacade
    {
        IStudentRepository StudentRepository;
        private readonly IMapper mapper;
        public StudentFacade(IStudentRepository StudentRepository, IMapper mapper)
        {
            this.StudentRepository = StudentRepository;
            this.mapper = mapper;
        }
        public StudentDTO Get(int id)
        {
            Student student = StudentRepository.Get(id);
            StudentDTO studentDTO = mapper.Map<Student, StudentDTO>(student);
            return studentDTO;
        }
        public IEnumerable<StudentDTO> GetAll()
        {
            IEnumerable<Student> student = StudentRepository.GetAll();
            IEnumerable<StudentDTO> studentDTO = mapper.Map<IEnumerable<Student>, IEnumerable<StudentDTO>>(student);
            return studentDTO;
        }
        public int Create(StudentDTO student)
        {
            Student createStudent = mapper.Map<StudentDTO, Student>(student);
            var result = StudentRepository.Create(createStudent);
            return result;
        }
        public int Edit(StudentDTO student)
        {
            Student createStudent = mapper.Map<StudentDTO, Student>(student);
            return StudentRepository.Edit(createStudent);
        }
        public void Delete(int id)
        {
            StudentRepository.Delete(id);
        }
    }
}
