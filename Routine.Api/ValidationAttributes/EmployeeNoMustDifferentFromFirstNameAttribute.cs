using System.ComponentModel.DataAnnotations;
using Routine.Api.Models;

namespace Routine.Api.ValidationAttributes
{
    public class EmployeeNoMustDifferentFromFirstNameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var addDto = (EmployeeAddDto) validationContext.ObjectInstance;

            if (addDto.EmployeeNo == addDto.FirstName)
            {
                return new ValidationResult("員工編號與名字不可相同",
                    new[] { nameof(EmployeeAddDto)});
            }

            return ValidationResult.Success;
        }
    }
}
