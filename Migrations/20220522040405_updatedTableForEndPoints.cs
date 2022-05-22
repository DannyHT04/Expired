using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expired.Migrations
{
    public partial class updatedTableForEndPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserNameInGroup",
                value: "Danny,Jovann,Trent,");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserNameInGroup",
                value: "Danny,Jovann,");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserNameInGroup",
                value: "Trent,");

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "isGroceryList",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserNameInGroup",
                value: "Trent");

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 6,
                column: "isGroceryList",
                value: false);
        }
    }
}
