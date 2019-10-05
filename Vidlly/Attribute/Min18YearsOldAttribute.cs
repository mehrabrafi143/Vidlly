using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vidlly.ViewModels;

namespace Vidlly.Models
{
    public class Min18YearsOldAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MemberShipTypeId == CustomerViewModel.Unknown || customer.MemberShipTypeId == CustomerViewModel.PayAsYouGo)
            {
                return ValidationResult.Success;
            }


            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is Require");
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            if (age >= 18)
            {
                return ValidationResult.Success;

            }

            return new ValidationResult("Need To be 18 years");


        }
    }
}