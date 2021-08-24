using Routine.Api.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Routine.Api.Models
{
    public class EmployeeAddDto
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
    }
}
