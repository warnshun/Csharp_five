using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Routine.Api.Models
{
    public class CompanyAddDto
    {
        [Display(Name = "公司名稱")]
        [Required(ErrorMessage = "{0}是必填的")]
        [MaxLength(100, ErrorMessage = "{0}的長度最大為 {1}")]
        public string Name { get; set; }

        [Display(Name = "公司簡介")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "{0}的長度範圍為 {2} ~ {1}")]
        public string Introduction { get; set; }

        public ICollection<EmployeeAddDto> Employees { get; set; } = new List<EmployeeAddDto>();
    }
}
