﻿using FiveApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public EmployeeRepository()
        {
            _employees.Add(new Employee { 
                Id = 1,
                DepartmentId = 1,
                FirstName = "Nick",
                LastName = "Carter",
                Gender = Gender.Male
            });
            _employees.Add(new Employee { 
                Id = 2,
                DepartmentId = 1,
                FirstName = "Michael",
                LastName = "Jackson",
                Gender = Gender.Male
            });
            _employees.Add(new Employee { 
                Id = 3,
                DepartmentId = 1,
                FirstName = "Mariah",
                LastName = "Carey",
                Gender = Gender.Female
            });
        }
        public Task<Employee> Add(Employee employee)
        {
            employee.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add(employee);
            return Task.Run(() => employee);
        }

        public Task<Employee> Fire(int id)
        {
            return Task.Run(() =>
            {
                var employee = _employees.FirstOrDefault(e => e.Id == id);

                if (employee != null)
                {
                    employee.IsFired = true;
                    return employee;
                }
                return null;
            });
        }

        public Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId)
        {
            return Task.Run(() => _employees.Where(x => x.DepartmentId == departmentId));
        }

        public Task<Employee> GetById(int id)
        {
            return Task.Run(() => _employees.FirstOrDefault(x => x.Id == id));
        }
    }
}
