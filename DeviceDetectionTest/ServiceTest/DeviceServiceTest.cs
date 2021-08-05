using DeviceDetector.Database.Entity;
using DeviceDetector.Models;
using DeviceDetector.Repository;
using DeviceDetector.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DeviceDetectionTest.ServiceTest
{
    public class DeviceServiceTest
    {
        private readonly DeviceService deviceService;
        private readonly Mock<IDeviceRepository> _mock = new Mock<IDeviceRepository>();

        public DeviceServiceTest()
        {
            deviceService = new DeviceService(_mock.Object);
        }

        [Fact]
        public async Task GetDeviceList_ShouldReturnList_Service_Test()
        {
            //Arrange
            List<Device> devices = new List<Device>();
            devices.Add(new Device
            {
                OperatingSystem = "Windows",
                Browser = "Chrome",
                DeviceName = "Unknown",
                OsVersion = "windows-10",
                BrowserVersion = "92.0.4515.131",
                DeviceType = "desktop",
                Orientation = "landscape"
            });

            _mock.Setup(p => p.devices()).ReturnsAsync(devices);

            //Act
            var result = await deviceService.devices();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public async Task CreateDeviceData_ShouldInsertData_Service_Test()
        {
            //Arrange      

            DeviceModel devicemodel = new DeviceModel
            {
                Os  = "Windows",
                Browser = "Chrome",
                Device = "Unknown",
                Os_Version = "windows-10",
                Browser_Version = "92.0.4515.131",
                DeviceType = "desktop",
                Orientation = "landscape"
            };

            _mock.Setup(p => p.SaveDevice(It.IsAny<Device>())).ReturnsAsync(true);

            //Act
            var result = await deviceService.SaveDevice(devicemodel);

            //Assert
            Assert.True(result);
        }
    }
}
