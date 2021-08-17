using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using FivePage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FivePage.Pages.Department
{
    public class AddDepartmentModel : PageModel
    {
        private readonly IDepartmentService _departmentService;

        [BindProperty]
        public Models.Department Department { get; set; }

        public AddDepartmentModel(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _departmentService.Add(Department);
            return RedirectToPage("/Index");
        }
    }
}
