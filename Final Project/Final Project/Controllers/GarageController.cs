using Final_Project.Models;
using Final_Project.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GarageController : ControllerBase
    {
        private IGarageService garageService;

        public GarageController(IGarageService garageService)
        {
            this.garageService = garageService;
        }
        [EnableCors("http://localhost:3000")]
        [HttpGet("all")]
        public ICollection<Garage> GetAll()
        {
            return this.garageService.GetGarages(); ;
        }
        [EnableCors("http://localhost:3000")]
        [HttpPost("add")]
        public ActionResult Post([FromBody]Garage input)
        {
            this.garageService.AddGarage(input.Name,input.Town,input.Address);
            return Ok("success");
        }
        [EnableCors("http://localhost:3000")]
        [HttpGet("{id}")]
        public ActionResult<Garage> Get(int id)
        {
            return this.garageService.GetGarage(id);
        }
        
    }
}
