using DeviceDetector.Models;
using DeviceDetector.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceDetectorNET.Parser;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeviceDetector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientDeviceController : ControllerBase
    {
        private readonly IDeviceService deviceService;
        public ClientDeviceController(IDeviceService _deviceService) => deviceService = _deviceService;

        // GET: api/<DeviceController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await deviceService.devices();
            return Ok(data);
        }

        // POST api/<DeviceController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DeviceModel value)
        {
            var data = await deviceService.SaveDevice(value);
            return Ok(data);
        }

    }
}
