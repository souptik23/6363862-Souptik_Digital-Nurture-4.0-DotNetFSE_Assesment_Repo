using Microsoft.AspNetCore.Mvc;
using WebApplication1_6363862.Models;

namespace WebApplication1_6363862.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // Static hardcoded employee list
        private static List<Employee> employees = GetStandardEmployeeList();

        // ✅ GET: api/employee
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // ✅ PUT: api/employee/1
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return BadRequest("Invalid employee id");

            // Update existing values
            employee.Name = updatedEmployee.Name;
            employee.Salary = updatedEmployee.Salary;
            employee.Permanent = updatedEmployee.Permanent;
            employee.DateOfBirth = updatedEmployee.DateOfBirth;
            employee.Department = updatedEmployee.Department;
            employee.Skills = updatedEmployee.Skills;

            return Ok(employee);
        }

        // 🔧 Helper method to initialize hardcoded list
        private static List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 60000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    }
                },
                new Employee
                {
                    Id = 2,
                    Name = "Bob",
                    Salary = 70000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1992, 2, 2),
                    Department = new Department { Id = 2, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Java" }
                    }
                }
            };
        }
    }
}
