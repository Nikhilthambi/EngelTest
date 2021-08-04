using DeviceDetector.Models;
using DeviceDetector.Services;
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
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService deviceService;
        public DeviceController(IDeviceService _deviceService) => deviceService = _deviceService;
     
        // GET: api/<DeviceController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DeviceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DeviceController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DeviceModel value)
        {
            try
            {
                var data = await deviceService.SaveDevice(value);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // PUT api/<DeviceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DeviceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
