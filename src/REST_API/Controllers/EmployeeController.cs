﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public string Get() 
        {
            return "Returning from EmployeeController Get Method";
        }

        [HttpGet]
        public string GetEmployee()
        {
            return "Returning from EmployeeController GetEmployee Method";
        }
    }
}
