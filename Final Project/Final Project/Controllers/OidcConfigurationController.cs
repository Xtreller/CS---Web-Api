using Final_Project.Data;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Final_Project.Controllers
{
    public class OidcConfigurationController : Controller
    {
        private readonly ILogger<OidcConfigurationController> _logger;
        private ApplicationDbContext db;

        public OidcConfigurationController(IClientRequestParametersProvider clientRequestParametersProvider, ILogger<OidcConfigurationController> logger,ApplicationDbContext dbContex)
        {
            this.db = dbContex;
            ClientRequestParametersProvider = clientRequestParametersProvider;
            _logger = logger;
        }

        public IClientRequestParametersProvider ClientRequestParametersProvider { get; }
        [EnableCors("http://localhost:3000")]
        [HttpGet("authentication/{clientId}")]
        public ActionResult GetClientRequestParameters([FromRoute] string clientId)
        {
         return   Ok(this.db.Users.Find(clientId));
        }
    }
}
