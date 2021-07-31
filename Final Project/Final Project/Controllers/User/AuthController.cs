using Microsoft.AspNetCore.Mvc;
using System;

namespace Final_Project.Controllers.User
{
    [Route("api/[controller]/")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public ActionResult register()
        {
           
            return Ok("here");

        }
        public ActionResult<Guid> login()
        {
            var token = Guid.NewGuid();
            return token;
        }

        public ActionResult logout() {
            return Ok("logged out");
        }

    }
}
