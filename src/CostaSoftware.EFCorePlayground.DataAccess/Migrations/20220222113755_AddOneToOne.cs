using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostaSoftware.EFCorePlayground.DataAccess.Migrations
{
    public partial class AddOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    LogoHighResUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoVectorUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TenantSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OfflineTimeoutMinutes = table.Column<int>(type: "int", nullable: false),
                    BreadcrumbsPrecision = table.Column<int>(type: "int", nullable: false),
                    SnapToRoadEngineApiKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenantSettings_Tenants_Id",
                        column: x => x.Id,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_Code",
                table: "Tenants",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TenantSettings");

            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
