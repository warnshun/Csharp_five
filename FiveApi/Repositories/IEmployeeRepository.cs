using FiveApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveApi.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> Add(Employee employee);

        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);

        Task<Employee> GetById(int id);

        Task<Employee> Fire(int id);
    }
}
