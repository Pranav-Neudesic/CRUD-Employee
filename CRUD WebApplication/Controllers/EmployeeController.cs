using CRUD_WebApplication.Data;
using CRUD_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            return Ok(await _repository.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            var employee = await _repository.GetEmployeeById(id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(Employee employee)
        {
            await _repository.AddEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.Id)
                return BadRequest();

            await _repository.UpdateEmployee(employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            await _repository.DeleteEmployee(id);
            return NoContent();
        }
    }
}

