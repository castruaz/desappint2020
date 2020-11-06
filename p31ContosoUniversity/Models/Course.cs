using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name="Numero")]
        public int CourseID {get; set;}
        [StringLength(50, MinimumLength=3)]
        public string Title {get; set;}
        [Range(0,7)]
        public int Credits {get; set;}
        public int DeparmentID {get; set;}

        public Department Department {get; set;}
        public ICollection<Enrollment> Enrollments {get; set;}
        public ICollection<CourseAssignment> CourseAssignments {get; set;}
    }
}