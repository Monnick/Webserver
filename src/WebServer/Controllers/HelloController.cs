using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetHello()
        {
            await Task.CompletedTask;

            return "hello from " + (Environment.GetEnvironmentVariable("HOSTNAME") ?? "bare metal computer");
        }
    }
}
