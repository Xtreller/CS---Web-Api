using Final_Project.Common;
using Final_Project.InputModels.Garages;
using Final_Project.Models;
using Final_Project.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GarageController : ControllerBase
    {
        private ILogger<GarageController> logger;
        private IGarageService garageService;

        public GarageController(IGarageService garageService, ILogger<GarageController> _logger)
        {
            this.logger = _logger;
            this.garageService = garageService;
        }
        [EnableCors("http://localhost:3000")]
        [HttpGet("all")]
        public IActionResult GetAll()   
        {
            return Ok(this.garageService.GetGarages());
        }

        [EnableCors("http://localhost:3000")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("add")]
        public ActionResult Post([FromBody] GarageInput input)
        {

            //return Ok(input.User_Id);
            this.garageService.AddGarage(input);
            return Ok(new Response() { Data = "succes", Success = true });
        }

        [EnableCors("http://localhost:3000")]
        [HttpGet("{id}")]
        public ActionResult<Garage> Get(int id)
        {
            return this.garageService.GetGarage(id);
        }

    }
}
