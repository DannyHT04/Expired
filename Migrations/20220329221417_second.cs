using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expired.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GroupsInfo",
                columns: new[] { "Id", "GroupName", "GroupPassword", "IsGroupDeleted" },
                values: new object[] { 1, "Test", "123", false });

            migrationBuilder.InsertData(
                table: "GroupsInfo",
                columns: new[] { "Id", "GroupName", "GroupPassword", "IsGroupDeleted" },
                values: new object[] { 2, "Another Group", "321", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
