using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.Models.Interface;
using api.Models;


namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public List<string> Get()
        {
            List<string> newList = new List<string>(){"This is the user string"};

            return newList;
        }

        [EnableCors("AnotherPolicy")]

        // GET: api/User/5
        [HttpGet("{userID}", Name = "GetUser")]
        public string Get(int id)
        {
             IGetUser readobject = new GetUserData();

            return readobject.GetUser(id).ToString();
            
                }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
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
