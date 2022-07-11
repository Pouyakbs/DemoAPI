using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
