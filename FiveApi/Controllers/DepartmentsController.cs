using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveApi.Models;
using FiveApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FiveApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        
        [HttpGet] // v1/Departments verb: Get
        public async Task<ActionResult<IEnumerable<Department>>> GetAll()
        {
            var departments = await _departmentRepository.GetAll();

            if (!departments.Any())
            {
                return NoContent();
            }

            return Ok(departments);
            // return new ObjectResult(departments);
        }

        [HttpPost] // v1/Departments verb: POST
        public async Task<ActionResult<Department>> Add([FromBody]Department department)
        {
            var added = await _departmentRepository.Add(department);

            return Ok(added);
        }
    }
}