using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testapi_powerplatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlowCall : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public FlowCall(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FlowCallRet> Get()
        {
            var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;

            return Enumerable.Range(1, 1).Select(index => new FlowCallRet
            {
                URLOri = remoteIpAddress.ToString()
            }).ToArray();
        }
    }
}