using DeviceDetector.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceDetector.Repository
{
    public interface IDeviceRepository
    {
        Task<bool> SaveDevice(Device device);
    }
}
