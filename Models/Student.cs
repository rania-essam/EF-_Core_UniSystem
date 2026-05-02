using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFday1_UniversitySystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ConcurrencyCheck]

        public int Age { get; set; }
        public string Email { get; set; }

        public bool IsDeleted { get; set; } = false;
        public int? DepartmentId { get; set; }

       public Department Department { get; set; }

     
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
