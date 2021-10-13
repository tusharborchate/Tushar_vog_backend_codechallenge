using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.Business.Interfaces;
using VogCodeChallenge.Entities.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployee _employee;

        public EmployeesController(IEmployee employee)
        {
            _employee = employee;
        }
        // GET: api/<Employees>
        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return _employee.GetAll();
        }

        // GET: api/<Employees>
        [HttpGet("department/{departmentId}")]
        public IEnumerable<Employee> ListAll([FromRoute]int departmentId)
        {
            return _employee.ListAll().Where(a=>a.DepartmentId==departmentId);
        }


    }
}
