using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;

namespace REST_API.Controllers
{
    
    //[ApiController]
    public class Employee2Controller : ControllerBase
    {
        [Route("Emp/All")]
        [HttpGet]
        public string GetAllEmployees() 
        {
            return "Response from GetAllEmployees method";
        }

        //[Route("Emp/ById/{Id}")]
        [Route("Employee/{Id}")]
        [HttpGet]
        public string GetEmployeeById(int id) 
        {
            return "Response from GetEmployeeById method";
        }

        [Route("Employee/{gender}/{city}")]
        [HttpGet]
        public string GetEmployeeByGenderAndCity(string gender, string city) 
        {
            return "Response from GetEmployeeByGenderAndCity method";
        }

        [Route("Employee/Search1")]
        [HttpGet]
        public string SearchEmployees(string department) 
        {
            return $"Return employees with department: {department}";
        }

        [Route("Employee/Search2")]
        [HttpGet]
        public string SearchEmployees(string? department, string? gender, string? city)
        {
            return $"Return employees with department: {department}, gender: {gender}, city: {city}";
        }

        [Route("Employee/Search3")]
        [HttpGet]
        public string SearchEmployees([FromQuery]EmployeeSearch search)
        {
            return $"Return employees with department: {search.department}, " +
                $"gender: {search.gender}, city: {search.city}";
        }

        [Route("Employee/Search")]
        [HttpGet]
        public string SearchEmployees()
        {
            var department = HttpContext.Request.Query["department"].ToString();
            var gender = HttpContext.Request.Query["gender"].ToString();
            var city = HttpContext.Request.Query["city"].ToString();

            return $"Return employees with department: {department}, " +
                $"gender: {gender}, city: {city}";
        }
    }
}
