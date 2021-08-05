using DeviceDetector.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeviceDetector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerDeviceController : ControllerBase
    {
        // GET api/<ServerDeviceController>/5
        [HttpGet()]
        public IActionResult Get(string id)
        {
            var result = DeviceDetectorNET.DeviceDetector.GetInfoFromUserAgent(id);
            Model model = new Model
            {
                Browser = result.Match.BrowserFamily,
                Os = result.Match.Os.Name,
                DeviceType = result.Matches[0].DeviceType,
                Browser_version = result.Match.Client.Version,
                Os_version = $"{result.Match.Os.Name} {result.Match.Os.Version}",
                UserAgent = id
            };
            return Ok(model);
        }
    }
}
