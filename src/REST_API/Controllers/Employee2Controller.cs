using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet]
        public string GetEmployeeById(int id) 
        {
            return "Response from GetEmployeeById method";
        }
    }
}
