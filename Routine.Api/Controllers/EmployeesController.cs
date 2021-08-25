using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Routine.Api.Entities;
using Routine.Api.Models;
using Routine.Api.Services;

namespace Routine.Api.Controllers
{
    [ApiController]
    [Route("api/companies/{companyId}/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public EmployeesController(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository ?? throw new ArgumentNullException(nameof(companyRepository));
            _mapper = mapper ?? throw  new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> 
            GetEmployeesForCompany(Guid companyId, 
                [FromQuery(Name = "gender")] string genderDisplay,
                string searchTerm)
        {
            if (!await _companyRepository.CompanyExistsAsync(companyId))
            {
                return NotFound();
            }

            var employees = await _companyRepository.GetEmployeesAsync(companyId, genderDisplay, searchTerm);

            var employeeDtos = _mapper.Map<IEnumerable<EmployeeDto>>(employees);

            return Ok(employeeDtos);
        }

        [HttpGet("{employeeId}", Name = nameof(GetEmployeeForCompany))]
        public async Task<ActionResult<EmployeeDto>> GetEmployeeForCompany(Guid companyId, Guid employeeId)
        {
            if (!await _companyRepository.CompanyExistsAsync(companyId))
            {
                return NotFound();
            }

            var employee = await _companyRepository.GetEmployeeAsync(companyId, employeeId);

            if (employee == null)
            {
                return NotFound();
            }

            var employeeDto = _mapper.Map<EmployeeDto>(employee);

            return Ok(employeeDto);
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> CreateEmployeeForCompany(Guid companyId, EmployeeAddDto employee)
        {
            if (!await _companyRepository.CompanyExistsAsync(companyId))
            {
                return NotFound();
            }

            var entity = _mapper.Map<Employee>(employee);

            _companyRepository.AddEmployee(companyId, entity);
            await _companyRepository.SaveAsync();

            var returnDto = _mapper.Map<EmployeeDto>(entity);

            return CreatedAtRoute(nameof(GetEmployeeForCompany), 
                new {companyId, employeeId = returnDto.Id},
                returnDto);
        }

        [HttpPut("{employeeId}")]
        public async Task<ActionResult<EmployeeDto>> UpdateEmployeeForCompany(
            Guid companyId,
            Guid employeeId,
            EmployeeUpdateDto employee)
        {
            if (!await _companyRepository.CompanyExistsAsync(companyId))
            {
                return NotFound();
            }

            var employeeEntity = await _companyRepository.GetEmployeeAsync(companyId, employeeId);

            if (employeeEntity == null)
            {
                var employeeToAddEntity = _mapper.Map<Employee>(employee);
                employeeToAddEntity.Id = employeeId;

                _companyRepository.AddEmployee(companyId, employeeToAddEntity);

                await _companyRepository.SaveAsync();

                var returnDto = _mapper.Map<EmployeeDto>(employeeToAddEntity);

                return CreatedAtRoute(nameof(GetEmployeeForCompany),
                    new { companyId, employeeId = returnDto.Id },
                    returnDto);
            }

            // Entity 映射為 UpdateDto
            // 把傳進來的 employee(UpdateDto) 的值賦予 UpdateDto
            // 把 UpdateDto 映射回 Entity

            _mapper.Map(employee, employeeEntity);

            
            _companyRepository.UpdateEmployee(employeeEntity);

            await _companyRepository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{employeeId}")]
        public async Task<IActionResult> PartiallyUpdateEmployeeForCompany(
            Guid companyId,
            Guid employeeId,
            JsonPatchDocument<EmployeeUpdateDto> patchDocument)
        {
            if (!await _companyRepository.CompanyExistsAsync(companyId))
            {
                return NotFound();
            }

            var employeeEntity = await _companyRepository.GetEmployeeAsync(companyId, employeeId);

            if (employeeEntity == null)
            {
                var employeeDto = new EmployeeUpdateDto();
                patchDocument.ApplyTo(employeeDto, ModelState);
                
                if (!TryValidateModel(employeeDto))
                {
                    return ValidationProblem(ModelState);
                }

                var employeeToAddEntity = _mapper.Map<Employee>(employeeDto);
                employeeToAddEntity.Id = employeeId;

                _companyRepository.AddEmployee(companyId, employeeToAddEntity);

                await _companyRepository.SaveAsync();

                var returnDto = _mapper.Map<EmployeeDto>(employeeToAddEntity);

                return CreatedAtRoute(nameof(GetEmployeeForCompany), new
                {
                    companyId,
                    employeeId = returnDto.Id
                }, returnDto);
            }

            var patchDto = _mapper.Map<EmployeeUpdateDto>(employeeEntity);

            // 需要驗證處理錯誤 (ModelState)
            patchDocument.ApplyTo(patchDto, ModelState);

            // 驗證
            if (!TryValidateModel(patchDto))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(patchDto, employeeEntity);

            _companyRepository.UpdateEmployee(employeeEntity);

            await _companyRepository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> DeleteEmployeeForCompany(Guid companyId, Guid employeeId)
        {
            if (!await _companyRepository.CompanyExistsAsync(companyId))
            {
                return NotFound();
            }

            var employee = await _companyRepository.GetEmployeeAsync(companyId, employeeId);

            if (employee == null)
            {
                return NotFound();
            }

            _companyRepository.DeleteEmployee(employee);

            await _companyRepository.SaveAsync();

            return NoContent();
        }

        public override ActionResult ValidationProblem(ModelStateDictionary modelStateDictionary)
        {
            var options = HttpContext.RequestServices
                .GetRequiredService<IOptions<ApiBehaviorOptions>>();

            return (ActionResult) options.Value.InvalidModelStateResponseFactory(ControllerContext);
        }
    }
}
