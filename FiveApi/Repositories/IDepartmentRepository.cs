using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveApi.Models;

namespace FiveApi.Repositories
{
    public interface IDepartmentRepository
    {
        Task<Department> Add(Department model);

        Task<IEnumerable<Department>> GetAll();

        Task<Department> GetById(int id);
    }
}
