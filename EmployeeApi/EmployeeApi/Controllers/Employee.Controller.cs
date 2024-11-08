using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;
using EmployeeApi.Services;
using System;
using System.Collections.Generic;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("Register")]
        public IActionResult RegisterEmployee([FromBody] Employee employee)
        {
            try
            {
                _employeeService.RegisterEmployee(employee);
                return Ok(new { message = "Employee successfully registered." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetEmployees")]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}