using DeviceDetector.Database;
using DeviceDetector.Database.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceDetector.Repository
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly DatabaseContext dbContext;
        public DeviceRepository(DatabaseContext _databaseContext) => dbContext = _databaseContext;

        public async Task<List<Device>> devices()
        {
            try
            {
                var data =await dbContext.Device.ToListAsync();
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> SaveDevice(Device device)
        {
            try
            {
                var data = dbContext.Device.Add(device);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
