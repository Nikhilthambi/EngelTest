using DeviceDetector.Database.Entity;
using DeviceDetector.Models;
using DeviceDetector.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceDetector.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository deviceRepository;
        public DeviceService(IDeviceRepository _deviceRepository) => deviceRepository = _deviceRepository;
        public async Task<bool> SaveDevice(DeviceModel device)
        {
            try
            {
                Device device1 = new Device
                {
                    Browser = device.Browser,
                    BrowserVersion = device.Browser_Version,
                    DeviceName = device.Device,
                    DeviceType = device.DeviceType,
                    OperatingSystem = device.Os,
                    Orientation = device.Orientation,
                    OsVersion = device.Os_Version,
                    UserAgent = device.UserAgent
                };
                var data = await deviceRepository.SaveDevice(device1);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
