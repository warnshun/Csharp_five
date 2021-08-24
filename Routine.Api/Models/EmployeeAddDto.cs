using Routine.Api.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Routine.Api.ValidationAttributes;

namespace Routine.Api.Models
{
    [EmployeeNoMustDifferentFromFirstName(ErrorMessage = "員工編號與名字不可相同！！")]
    public class EmployeeAddDto : IValidatableObject
    {
        [Display(Name = "員工編號"), 
        Required(ErrorMessage = "{0} 是必填的"),
        StringLength(10, MinimumLength = 10, ErrorMessage = "{0} 的長度為 {1}")]
        public string EmployeeNo { get; set; }

        [Display(Name = "名字"),
        Required(ErrorMessage = "{0} 是必填的"),
        MaxLength(50, ErrorMessage = "{0} 最大長度為 {1}")]
        public string FirstName { get; set; }

        [Display(Name = "姓氏"),
         Required(ErrorMessage = "{0} 是必填的"),
         MaxLength(50, ErrorMessage = "{0} 最大長度為 {1}")]
        public string LastName { get; set; }

        [Display(Name = "性別")]
        public Gender Gender { get; set; }

        [Display(Name = "出生日期")]
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstName == LastName)
            {
                yield return new ValidationResult("姓氏與名字不可相同", 
                    new []{nameof(FirstName), nameof(LastName) });
            }
        }
    }
}
