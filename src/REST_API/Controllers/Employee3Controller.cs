using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee3Controller : ControllerBase
    {
        [HttpGet("Details")]
        public Employee GetEmployeeDetails()
        {
            return new Employee()
            {
                Id = 1001,
                Name = "Achini",
                Age = 35,
                City = "Colombo",
                Gender = "Female",
                Department = Department.IT
            };
        }

        [HttpGet("All")]
        public List<Employee> GetAllEmployee() 
        {
            return new List<Employee>() 
            {
                new Employee() { Id = 1, Name = "Jon", Age = 20, City = "New York", Department = Department.HR, Gender = "Male"},
                new Employee() { Id = 2, Name = "Eva", Age = 28, City = "Amstardam", Department = Department.Finance, Gender = "Female"},
                new Employee() { Id = 3, Name = "Alex", Age = 30, City = "Briston", Department = Department.Marketing, Gender = "Male"}
            };
        }

        [HttpGet("All2")]
        public IEnumerable<Employee> GetAllEmployee2()
        {
            return new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Jon", Age = 20, City = "New York", Department = Department.HR, Gender = "Male"},
                new Employee() { Id = 2, Name = "Eva", Age = 28, City = "Amstardam", Department = Department.Finance, Gender = "Female"},
                new Employee() { Id = 3, Name = "Alex", Age = 30, City = "Briston", Department = Department.Marketing, Gender = "Male"}
            };
        }

        [HttpGet("All3")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Employee>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllEmployee3() 
        {
            try 
            {
                var listEmployees = new List<Employee>() 
                {
                    new Employee() { Id = 1, Name = "Jon", Age = 20, City = "New York", Department = Department.HR, Gender = "Male"},
                    new Employee() { Id = 2, Name = "Eva", Age = 28, City = "Amstardam", Department = Department.Finance, Gender = "Female"},
                    new Employee() { Id = 3, Name = "Alex", Age = 30, City = "Briston", Department = Department.Marketing, Gender = "Male"}
                };

                if (listEmployees.Any())
                {
                    return Ok(listEmployees);
                }
                else 
                {
                    return NotFound();
                }
            } catch (Exception ex) 
            {
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllEmployeeById(int Id)
        {
            try
            {
                var listEmployees = new List<Employee>()
                {
                    new Employee() { Id = 1, Name = "Jon", Age = 20, City = "New York", Department = Department.HR, Gender = "Male"},
                    new Employee() { Id = 2, Name = "Eva", Age = 28, City = "Amstardam", Department = Department.Finance, Gender = "Female"},
                    new Employee() { Id = 3, Name = "Alex", Age = 30, City = "Briston", Department = Department.Marketing, Gender = "Male"}
                };

                var employee = listEmployees.FirstOrDefault(e => e.Id == Id);
                if (employee != null)
                {
                    return Ok(employee);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request");
            }
        }
    }
}
