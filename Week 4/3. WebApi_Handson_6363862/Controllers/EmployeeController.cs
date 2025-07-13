using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1_6363862.Filters;
using WebApplication1_6363862.Models;

namespace WebApplication1_6363862.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))] // We'll define this later
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill> {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    }
                },
                new Employee
                {
                    Id = 2,
                    Name = "Bob",
                    Salary = 60000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1992, 5, 1),
                    Department = new Department { Id = 2, Name = "IT" },
                    Skills = new List<Skill> {
                        new Skill { Id = 3, Name = "Java" }
                    }
                }
            };
        }

        // GET api/employee
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetStandard()
        {
            //throw new Exception("Test exception"); // Uncomment to test exception filter
            return Ok(employees);
        }

        // POST api/employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee emp)
        {
            // just return back what was received
            return Ok(emp);
        }
    }
}
