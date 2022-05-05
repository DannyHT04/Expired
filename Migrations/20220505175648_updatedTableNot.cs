using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expired.Migrations
{
    public partial class updatedTableNot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "ItemInfo",
                newName: "NotificationDate");

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/13/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfExpiration", "NotificationDate" },
                values: new object[] { "04/15/2022", "04/13/2022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotificationDate",
                table: "ItemInfo",
                newName: "Category");

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Dairy", "04-13-2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Food", "04-15-2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Drink", "06-13-2023" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Dairy", "04-27-2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Food", "06-13-2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Food", "04-26-2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Food", "04-27-2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Food", "04-27-2022" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Food", "07-26-2023" });

            migrationBuilder.UpdateData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "DateOfExpiration" },
                values: new object[] { "Food", "04-02-2022" });
        }
    }
}
