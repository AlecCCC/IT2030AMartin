﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EnrollmentApplication.Models
{
    public class Enrollment : DropCreateDatabaseAlways<EnrollmentDB>
    {
        public virtual int EnrollmentId { get; set; }
 
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        [Required]
        [RegularExpression("[A-DF]", ErrorMessage ="Enter A, B, C, D, or F for a Grade.")]

        public virtual string Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        public bool IsActive { get; set; }

        [Required (ErrorMessage ="Please Enter your assigned campus")]
        [Display(Name ="Assigned Campus")]
        public string AssignedCampus { get; set; }

        [Required(ErrorMessage = "Please Enter your Enrollment Semester")]
        [Display(Name = "Enrolled in Semester")]
        public string EnrollmentSemester { get; set; }
        [Required(ErrorMessage = "Please Enter your Enrollment Year")]
        [Range(2018,2999, ErrorMessage ="Year cannot be less than 2018")]
        public int EnrollmentYear { get; set; }

        [InvalidChars("*")]

        public string Notes { get; set; }


    }
}