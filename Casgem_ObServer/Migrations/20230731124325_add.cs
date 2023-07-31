using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casgem_ObServer.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserProsesSurname",
                table: "UserProseses",
                newName: "UserProsesNameSurname");

            migrationBuilder.RenameColumn(
                name: "UserProsesName",
                table: "UserProseses",
                newName: "UserProsesContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserProsesNameSurname",
                table: "UserProseses",
                newName: "UserProsesSurname");

            migrationBuilder.RenameColumn(
                name: "UserProsesContent",
                table: "UserProseses",
                newName: "UserProsesName");
        }
    }
}
