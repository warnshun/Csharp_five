using FivePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FivePage.Services
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);

        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);

        Task<Employee> Fire(int id);
    }
}
