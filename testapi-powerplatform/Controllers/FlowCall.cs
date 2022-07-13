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
        [HttpGet]
        public IEnumerable<FlowCallRet> Get()
        {
            var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
            var remotePort = Request.HttpContext.Connection.RemotePort;

            var localIpAddress = Request.HttpContext.Connection.LocalIpAddress;
            var localPort = Request.HttpContext.Connection.LocalPort;



            return Enumerable.Range(1, 1).Select(index => new FlowCallRet
            {
                URLOri = remoteIpAddress.ToString(),
                PortOri = remotePort.ToString(),

                URLLocal = localIpAddress.ToString(),
                PortLocal = localPort.ToString()

            }).ToArray();
        }
    }
}