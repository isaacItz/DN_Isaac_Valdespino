using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessExampleEntityFramework.Migrations
{
    public partial class IncentiveMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValidTil",
                table: "VehicleIncentives",
                newName: "ValidTill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValidTill",
                table: "VehicleIncentives",
                newName: "ValidTil");
        }
    }
}
