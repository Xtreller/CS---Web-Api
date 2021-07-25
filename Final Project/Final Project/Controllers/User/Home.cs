using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Final_Project.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {

        [HttpGet("/index")]
        public HttpResponseMessage Index()
        {
            Console.WriteLine("Hesoyam");
            var car = new List<string>() {"123","1234","123","123" };
            return new HttpResponseMessage() { Content= new StringContent("console")};
            
        }
    }
}
