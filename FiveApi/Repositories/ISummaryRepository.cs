using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveApi.Models;

namespace FiveApi.Repositories
{
    public interface ISummaryRepository
    {
        Task<CompanySummary> GetCompanySummary();
    }
}
