﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Routine.Api.DtoParameters;
using Routine.Api.Entities;
using Routine.Api.Helpers;

namespace Routine.Api.Services
{
    public interface ICompanyRepository
    {
        Task<PagedList<Company>> GetCompaniesAsync(CompanyDtoParameters parameters);
        Task<IEnumerable<Company>> GetCompaniesAsync(IEnumerable<Guid> companyIds);
        Task<Company> GetCompanyAsync(Guid companyId);
        void AddCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);
        Task<bool> CompanyExistsAsync(Guid companyId);

        Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, EmployeeDtoParameters parameters);
        Task<Employee> GetEmployeeAsync(Guid companyId, Guid employeeId);
        void AddEmployee(Guid companyId, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        // Task<bool> EmployeeExistsAsync(Guid employeeId);

        Task<bool> SaveAsync();
    }
}
