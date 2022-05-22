using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expired.Migrations
{
    public partial class updatedTableForEndPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserNameInGroup",
                value: "Danny,Jovann,Trent");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserNameInGroup",
                value: "Danny,Jovann");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserNameInGroup",
                value: "Danny, Jovann, Trent");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserNameInGroup",
                value: "Danny, Jovann");
        }
    }
}
