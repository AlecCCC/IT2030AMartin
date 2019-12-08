using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventProject.Models
{
    public class DateValidate : ValidationAttribute
    {
        public DateValidate()
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}