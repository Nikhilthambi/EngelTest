using Microsoft.EntityFrameworkCore.Migrations;

namespace DeviceDetector.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    DeviceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAgent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OperatingSystem = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Browser = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OsVersion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BrowserVersion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Orientation = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.DeviceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device");
        }
    }
}
