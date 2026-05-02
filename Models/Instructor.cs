using System;
using System.Collections.Generic;
using System.Text;

namespace EFday1_UniversitySystem.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        
        public Department Department { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
