using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        readonly string InvalidChars;
        public InvalidCharsAttribute(string InvalidChars) :base("{0} contains unacceptable character")
        {
            this.InvalidChars = InvalidChars;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
        
            {

               if ((string)value !="*")


                {
                    var errormessage = FormatErrorMessage(validationContext.DisplayName);

                    return new ValidationResult(errormessage);
                }


            }

            return ValidationResult.Success;

           
        }
    }
}