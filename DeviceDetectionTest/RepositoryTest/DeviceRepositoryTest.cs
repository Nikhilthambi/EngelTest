using DeviceDetector.Database;
using DeviceDetector.Database.Entity;
using DeviceDetector.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;

namespace DeviceDetectionTest.RepositoryTest
{
    public class DeviceRepositoryTest
    {
        private DeviceRepository deviceRepository;

        public void Init()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "DeviceDbTest").Options;
            DatabaseContext context = new DatabaseContext(options);
            context.Database.EnsureDeleted();
            context.Device.Add(new Device
            {
                OperatingSystem = "Windows",
                Browser = "Chrome",
                DeviceName = "Unknown",
                OsVersion = "windows-10",
                BrowserVersion = "92.0.4515.131",
                DeviceType = "desktop",
                Orientation = "landscape"
            });
            context.SaveChanges();
            deviceRepository = new DeviceRepository(context);
        }

        [Fact]
        public async Task GetDeviceList_ShouldReturnList_RepoTest()
        {
            //Arrange
            Init();

            //Act
            var result = await deviceRepository.devices();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public async Task CreateDevice_ShouldInsert_RepoTest()
        {
            //Arrange
            Init();
            var data = new Device
            {
                OperatingSystem = "Windows",
                Browser = "Chrome",
                DeviceName = "Unknown",
                OsVersion = "windows-10",
                BrowserVersion = "92.0.4515.131",
                DeviceType = "desktop",
                Orientation = "landscape"
            };

            //Act
            var result = await deviceRepository.SaveDevice(data);

            //Assert
            Assert.True(result);
        }
    }
}
