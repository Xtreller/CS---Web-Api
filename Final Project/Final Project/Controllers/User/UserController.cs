using Final_Project.Data;
using Final_Project.Models;
using Final_Project.Services.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final_Project.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        // GET: api/<UserController>
        

        // GET api/user/:id
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            return Ok(userService.getUser(id));

        }

        // POST api/<UserController>
        [HttpPost("register")]
        public ApplicationUser Post([FromBody]ApplicationUser input)
        {
            
            return this.userService.register(input.Email, input.PasswordHash);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
