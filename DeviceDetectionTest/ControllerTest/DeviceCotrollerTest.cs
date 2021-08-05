using DeviceDetector.Controllers;
using DeviceDetector.Models;
using DeviceDetector.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DeviceDetectionTest.ControllerTest
{
    public class DeviceCotrollerTest
    {
        private readonly ClientDeviceController clientDeviceController;
        private readonly Mock<IDeviceService> _mock = new Mock<IDeviceService>();
        public DeviceCotrollerTest()
        {
            clientDeviceController = new ClientDeviceController(_mock.Object);
        }

        [Fact]
        public async Task DeviceList_ShouldReturnList_Controller_Test()
        {
            //Arrange
            List<DeviceModel> list = new List<DeviceModel>();
            list.Add(new DeviceModel
            {
                Os = "Windows",
                Browser = "Chrome",
                Device = "Unknown",
                Os_Version = "windows-10",
                Browser_Version = "92.0.4515.131",
                DeviceType = "desktop",
                Orientation = "landscape"
            });

            _mock.Setup(p => p.devices()).ReturnsAsync(list);

            //Act
            var result = await clientDeviceController.Get();
            var okResult = result as OkObjectResult;
            var okResultData = okResult.Value as List<DeviceModel>;

            //Assert
            Assert.Equal(200, okResult.StatusCode);
            Assert.True(okResultData.Count > 0);
        }

        [Fact]
        public async Task CreateDevice_ShouldInsert_Controller_Test()
        {
            //Arrange
            DeviceModel model = new DeviceModel
            {
                Os = "Windows",
                Browser = "Chrome",
                Device = "Unknown",
                Os_Version = "windows-10",
                Browser_Version = "92.0.4515.131",
                DeviceType = "desktop",
                Orientation = "landscape"
            };

            _mock.Setup(p => p.SaveDevice(model)).ReturnsAsync(true);

            //Act
            var result = await clientDeviceController.Post(model);
            var okResult = result as OkObjectResult;
            // var okResultData = okResult.Value as MyProperty;

            //Assert
            Assert.Equal(200, okResult.StatusCode);
            //Assert.True(okResultData);
        }
    }
}
