using DeviceDetector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceDetector.Services
{
    public interface IDeviceService
    {
        Task<bool> SaveDevice(DeviceModel device);
    }
}
