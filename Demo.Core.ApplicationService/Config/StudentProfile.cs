using AutoMapper;
using Demo.Core.Domain.DTOs;
using Demo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.ApplicationService.Config
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, Student>();
        }
    }
}
