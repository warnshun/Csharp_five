using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveApi.Models;

namespace FiveApi.Repositories
{
    interface ISummaryRepository
    {
        Task<CompanySummary> GetCompanySummary();
    }
}
