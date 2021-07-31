using Final_Project.Data;
using Final_Project.Models;
using Final_Project.Services;
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
            return Ok(userService.GetUserById(id));

        }

        // POST api/<UserController>
        [HttpPost("register")]
        public ActionResult<ApplicationUser> Register([FromBody] ApplicationUser input)
        {
            return this.userService.Register(input);

        }

        [HttpPost("login")]
        public ActionResult<string> Login([FromBody] ApplicationUser input)
        {
            string token;
            var user = this.userService.Login(input);
            if (user!=null) {
                token = GenerateJwt.Generate(user.Id);
                return token;
            }
            return Problem("User not found!");

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
