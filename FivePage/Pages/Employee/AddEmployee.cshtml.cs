using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FivePage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FivePage.Pages.Employee
{
    public class AddEmployeeModel : PageModel
    {
        private readonly IEmployeeService _employeeService;

        public AddEmployeeModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [BindProperty]
        public Models.Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync(int departmentId)
        {
            Employee.DepartmentId = departmentId;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _employeeService.Add(Employee);

            return RedirectToPage("EmployeeList", new {departmentId});
        }
    }
}
