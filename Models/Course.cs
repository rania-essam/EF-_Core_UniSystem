using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFday1_UniversitySystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }  

   
  


        public Instructor Instructor { get; set; }

        public int InstructorId { get; set; }




    }

    

}
