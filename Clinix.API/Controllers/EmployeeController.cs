using Clinix.Application.Dtos.Responses;
using Clinix.Application.Interfaces;
using Clinix.Core.Dtos.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinix.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<ActionResult<CreateEmployeeResponseDto>> CreateEmployee(CreateEmployeeRequestDto employeeDto)
        {
            return Created("Criado com Sucesso!", await _employeeService.CreateEmployeeServiceAsync(employeeDto));
        }

    }
}
