using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Required(ErrorMessage = "You need to enter a student ID.")]
        public virtual int StudentId { get; set; }

        [Required(ErrorMessage = "You need to enter a student Last Name.")]
        [StringLength(50, ErrorMessage = "Last name is too long.")]

        public virtual string LastName { get; set; }

        [Required(ErrorMessage = "You need to enter a student First Name.")]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        public virtual string FirstName { get; set; }
    }
}