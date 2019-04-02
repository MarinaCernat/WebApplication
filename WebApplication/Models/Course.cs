using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Course
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        
        [System.ComponentModel.DataAnnotations.Display(Name = "Number")]
        public int CourseID { get; set; }
       
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        
        [System.ComponentModel.DataAnnotations.Range(0, 5)]
        public int Credits { get; set; }
        
        public int DepartmentID { get; set; }
        
        public virtual Department Department { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}