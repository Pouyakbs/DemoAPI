using Demo.Core.Contracts.Facade;
using Demo.Core.Contracts.Repository;
using Demo.Core.Domain.DTOs;
using DemoPresentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentFacade studentRepository;

        public StudentController(IStudentFacade studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            ResponseViewModel<IEnumerable<StudentDTO>> model = new ResponseViewModel<IEnumerable<StudentDTO>>();
            try
            {
                model.Data = studentRepository.GetAll().ToList();
            }
            catch (Exception ex)
            {

                model.AddError(ex.Message);
                return BadRequest(model);
            }
            return Ok(model);
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            ResponseViewModel<StudentDTO> model = new ResponseViewModel<StudentDTO>();
            try
            {
                model.Data = studentRepository.Get(id);
            }
            catch (InvalidOperationException ex)
            {

                model.AddError("دانش اموز وجود ندارد");
                return NotFound(model);
            }
            return Ok(model);
        }

        [HttpPost]
        public IActionResult PostStudent(StudentDTO student)
        {
            ResponseViewModel<int> model = new ResponseViewModel<int>();
            try
            {
                model.Data = studentRepository.Create(student);
            }
            catch (Exception ex)
            {

                model.AddError(ex.Message);
                return BadRequest(model);
            }

            return Created($"/api/student/{model.Data}", model);
        }


        [HttpPut]
        public IActionResult PutStudent(StudentDTO student)
        {
            if (student.StudentId == 0)
            {
                return BadRequest("id کو؟");
            }
            studentRepository.Update(student);
            return Ok(student);
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            return null;

        }

        [Route("api/time")]
        [HttpGet]
        public string Time()
        {
            return DateTime.Now.ToString();
        }
    }
}
