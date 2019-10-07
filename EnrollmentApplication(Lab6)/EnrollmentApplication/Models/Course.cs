using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }
        [Required(ErrorMessage = "You need to enter a course title.")]
        [StringLength(150, ErrorMessage = "Course  Title is too long.")]
        [Display(Name = "Course Title")]
        public virtual string CourseTitle { get; set; }

        [Display(Name = "Description")]
        public virtual string CourseDesc { get; set; }

        [Required(ErrorMessage = "You need to enter a Grade.")]
        [Range (1,4,ErrorMessage = "Credit must be between 1-4") ]
        [Display(Name = "Number of Credits")]
        public virtual int CourseCredits { get; set; }
    }
}