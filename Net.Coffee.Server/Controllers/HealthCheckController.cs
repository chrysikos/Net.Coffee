using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net.Coffee.Server.Contracts;

namespace Net.Coffee.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        readonly ILogger<HealthCheckController> logger;
        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            this.logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            this.logger.LogInformation("Get Called.");
            return Ok(new DTOHealthCheckStatus()
            {
                Status = "OK",
                TimeStamp = DateTime.Now
            });
        }
    }
}
