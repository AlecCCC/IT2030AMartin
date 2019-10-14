using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {

        [Required(ErrorMessage = "You need to enter a student ID.")]
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Required(ErrorMessage = "You need to enter a student Last Name.")]
        [StringLength(50, ErrorMessage = "Last name is too long.")]
        [Display(Name = "Last Name")]

        public virtual string LastName { get; set; }

        [Required(ErrorMessage = "You need to enter a student First Name.")]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        [Display(Name = "First Name")]
        public virtual string FirstName { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
         
            var pAddress2 = new[] { "Address2" };
            if(Address2 == Address1)
                
            {

                {
                   yield return (new ValidationResult("Address 2 cannot be the same as Address 1",pAddress2));
                }

            }

            var pState = new[] { "State" };
  

            if (State.Length != 2 )
            {

                {
                    yield return (new ValidationResult("Enter a 2 digit State code", pState));
                }
            }

            var pZipcode = new[] { "Zipcode" };
            
            int zipcodelength = Zipcode.Length;
            
            if (Zipcode.Length != 5)
            {

                {
                    yield return (new ValidationResult("Enter a 5 digit Zipcode", pZipcode));
                }
            }

            throw new NotImplementedException();
       
        }
    }
}