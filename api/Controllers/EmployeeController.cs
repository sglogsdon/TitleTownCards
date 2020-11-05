using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;


namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/Employee
        [HttpGet]
        public List<string> Get()
        {
            List<string> newList = new List<string>(){"This is the employee string"};

            return newList;
        }
        [EnableCors("AnotherPolicy")]

        // GET: api/Employee/5
        [HttpGet("{employeeid}", Name = "GetEmployee")]
        public string Get(int id)
        {
            return "valuea";
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
