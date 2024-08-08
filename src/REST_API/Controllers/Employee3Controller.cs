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
    }
}
