using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EQR.DDS.Azure.Gateway.Lease.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EqrgrapiController : ControllerBase
    {
        private readonly ILogger<EqrgrapiController> _logger;
        public EqrgrapiController(ILogger<EqrgrapiController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ping")]
        public string Ping()
        {

            return "Lease Gateway API is running.";
        }
    }
}
