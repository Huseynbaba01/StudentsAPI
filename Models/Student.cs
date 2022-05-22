using System;
using System.Collections.Generic;

#nullable disable

namespace StudentsBackend.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Degree { get; set; }
    }
}
