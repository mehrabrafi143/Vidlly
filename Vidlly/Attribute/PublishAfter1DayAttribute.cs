using System;
using System.ComponentModel.DataAnnotations;

namespace Vidlly.Models
{
    public class PublishAfter1DayAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;

            if (movie.PublishDate  == null)
            {
                return new ValidationResult("Publish date can be null");
            }

            var day =(int) ((movie.PublishDate.Value - DateTime.Today  ).TotalDays);

            return (day >= 1) ? ValidationResult.Success : new ValidationResult("Must be after 1 day");
        }
    }
}