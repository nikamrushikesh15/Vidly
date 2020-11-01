using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YofOld:ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == 1) {

                return ValidationResult.Success;
            }
            if (customer.birthdate == null) {
                return new ValidationResult("Birthdate is required");


            }
            var age = DateTime.Today.Year - customer.birthdate.Value.Year;
            if (age > 18)
            {
                return ValidationResult.Success;
            }
            else {
                return new ValidationResult("age should be greater than 18");
            }
            return base.IsValid(value, validationContext);
        }
    }
}