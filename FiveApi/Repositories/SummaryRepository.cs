﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveApi.Models;

namespace FiveApi.Repositories
{
    public class SummaryRepository : ISummaryRepository
    {
        private readonly IDepartmentRepository _departmentRepository;

        public SummaryRepository(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public Task<CompanySummary> GetCompanySummary()
        {
            var all = _departmentRepository.GetAll().Result;

            return Task.Run(() =>
            {
                return new CompanySummary
                {
                    EmployeeCount = all.Sum(x => x.EmployeeCount),
                    AverageDepartmentEmployeeCount = (int)all.Average(x => x.EmployeeCount)
                };
            });
        }
    }
}
