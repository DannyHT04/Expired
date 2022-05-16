using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expired.Migrations
{
    public partial class groupname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsersInGroup",
                table: "GroupsInfo",
                newName: "UsersIdInGroup");

            migrationBuilder.AddColumn<string>(
                name: "UserNameInGroup",
                table: "GroupsInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserNameInGroup", "UsersIdInGroup" },
                values: new object[] { "Danny, Jovann, Trent", "1,2,3" });

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserNameInGroup", "UsersIdInGroup" },
                values: new object[] { "Danny, Jovann", "1,2" });

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserNameInGroup", "UsersIdInGroup" },
                values: new object[] { "Trent", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNameInGroup",
                table: "GroupsInfo");

            migrationBuilder.RenameColumn(
                name: "UsersIdInGroup",
                table: "GroupsInfo",
                newName: "UsersInGroup");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsersInGroup",
                value: "1,2");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsersInGroup",
                value: null);

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "UsersInGroup",
                value: null);
        }
    }
}
