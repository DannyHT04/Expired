using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expired.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupName",
                value: "Group 1");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "GroupName",
                value: "Group 2");

            migrationBuilder.InsertData(
                table: "GroupsInfo",
                columns: new[] { "Id", "GroupName", "GroupPassword", "IsGroupDeleted" },
                values: new object[] { 3, "Group 3", "ILovePanCakes", false });

            migrationBuilder.InsertData(
                table: "ItemInfo",
                columns: new[] { "Id", "Category", "DateOfExpiration", "GroupId", "Owner", "ProductImage", "ProductName", "UserId", "isDeleted", "isGroceryList" },
                values: new object[,]
                {
                    { 1, "Dairy", "04-13-2022", 1, "Danny", "I am a string of a png", "Milk", 1, false, true },
                    { 2, "Food", "04-15-2022", 1, "Danny", "I am a string of a png", "Bread", 1, false, false },
                    { 3, "Drink", "06-13-2023", 0, "Jovann", "I am a string of a png", "Pepsi", 2, false, true },
                    { 4, "Dairy", "04-27-2022", 0, "Jovann", "I am a string of a png", "Milk", 2, false, false },
                    { 5, "Food", "06-13-2022", 1, "Trent", "I am a string of a png", "Eggs", 3, false, true },
                    { 6, "Food", "04-26-2022", 1, "Trent", "I am a string of a png", "Steak", 3, false, false },
                    { 7, "Food", "04-27-2022", 2, "Billy", "I am a string of a png", "Steak", 4, false, true },
                    { 8, "Food", "04-27-2022", 2, "Billy", "I am a string of a png", "Bacon", 4, false, true },
                    { 9, "Food", "07-26-2023", 3, "Bob", "I am a string of a png", "Kimchi", 5, false, false },
                    { 10, "Food", "04-02-2022", 3, "Bob", "I am a string of a png", "Ranch", 5, false, false }
                });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "Id", "DeleteUser", "GroupId", "Hash", "Salt", "Username" },
                values: new object[,]
                {
                    { 1, false, 1, "949Ebs/nVwzi08Vdz7cZI28dbz4hHlyW93SXUWdcBWU4STLeFIgfOi/LXQNkb/mPi2LuRDwmEk7wEBVOvTS7FzS7n/qQyiw+zv1QQcOKMmzph30AFzUwltFJ69ahWEFslZw/NCV2GudMCHYFBqis3vllQokaEHo19sbzMqD3tU873JuQrCzJxXb0OdngKeJT5/jLddriZXToNsE5GTumrnnQOnG6P290eDd0VJHgCurjKzlchaNKzMYsotYgLmj3hrQIJKt0njjcEqsDtm6m+cFsJ9M5vY4INI0YKVOx5dQBuXC/spKNgDbx8x4g1xSzHtTTKwel1a94Yp0KfEkTBg==", "f3Kf9IhMiDpJXfLDGc7DM9n4lhyYUYXfQvhAROUHn5gw/fiYBL6OFZQ8t2OfutqmwQsGeD9dwgjh6MvUsBvqJA==", "Danny" },
                    { 2, false, 0, "SGJyUcgn2+R6+76gXMiGXBJhSh4jNt/b/GF5DEekKkUxMfxpCpO5zVTJLCLk176rW8+Ph5pYz/D1TERfEDgPv6haP78Ogj3DTG2GiT9QdZv9RBAmQqPUBKe/OjOWBDlm6Y49ITOxLiHFXBDV5jxyOfMEhMjlT1Gy99a3jfckkMjFwFjMLCvBXEFyoPLYCMlJbVcNyVtyVo8lkftndoProogigDa5atoNr8RqdoLRQ3/6zhI8zvo6rNMJ5wr96uv0dGmH6TUk48Bqomu923HcavY0YBJ1xL8f1Hne214EDbAmPUxACpVLuhTdviPefb+FHcQ9H8SrvuyaQwGe/CkEkA==", "PiLgqPNAW96VxCyUSVX7KMQWHDS8bFX9PbMG8QgV3pn+A+ITCYaLo3M5yw5ShKdORqP5R9/fQTP0WNL6X1D96Q==", "Jovann" },
                    { 3, false, 1, "gOsplAgVxvbNR/w/KO4kzFVHjbQ8CaMCSs04v0QDK7hDe+szWMykqlqdEWKky4HXOhZobZWSEmFH7NMuimKMrx1OClQD6g0XIh6CK8+Ai6ZRtOo7I8ZJbtwRi9Kj+9ee44V8DZhvbRrFh2E25ooQSgF3EP+h1CmUQMVnPqAvV6Evo7lWj+s/Z2GquauBn+H2tDNQekTlaSmta97uOlKE73skCqsZmlDAQNFNDlCOarNN+1x3njSXhEHL1u9CoTyHTwlE6WDMMIUqS6ksWiUNWvwld3UXiIUAyqmrxI692jhs46w9R64cpiZ/sB0RfK88YB4w1/PlILAJcSbNNWoZUg==", "2DxKtfn6ksuh64AaVURKyOGTuPtCsaURi2DpIDZugt/oRWuQfqMNpODbbJR+dCECzkahus/iQnReNxHPx6Wwpw==", "Trent" },
                    { 4, false, 2, "CRJLCq7aB48R4+fMkt76lrn0g6fBfgIjXu5p5CUoIK0/sEU+bFjw1A2y895HznAOuxdHlbaauCcqs/a6nYRoX5dro6pulsEWXXUuSNwuoTBUcnkjaQPljj5/SBiTuZX3IKxcdZVJlfFiOW1veZPPOYLI5G5bKnZnGFQ76xEw6KJLWxmLnXHmyjwZPm3jHTVWuOF6jFf+D8Tzo49Hk47tDOg4BzKk0L/HStJlrxicWSBy+g2brAPAypkd0e6wjQgGPlJWQp+5mYRaQW0Z+rrFxVyvkIZ03k6ObEnUevXci82rAQgmeBqvMOMGsrlWX65mCAxX0S4JOR6NeOORSTP/aw==", "xKJOIM0ZBtosw7Wmcjc7ZLLO7cOvFZbFxzD3u696PMkCUiDqcj4Ws9pDJVZXtvdo8GnGSH+WEeZFJRryjUy1yQ==", "Billy" },
                    { 5, false, 3, "vvWpOiwl8uuKV9tWFs8mSnyM0xbzAosalTZa2c3FTrXFWRKmaPPb48/YREIT/jVpfgMvjfrG70hxi/buJInFJufKdiBPsRxqRnkImRPFvg7SF+5TAfKWCL1jXpeB3+EsQ3EIi0fD+nYdr6Gn1M+lo1gQp6L/0DnMR/uI1pykdWbOS9/f5Bxj1E7FPlQhkSsHPmYsOczoWOmea8/y3yxKcKWNoZarrxfLe4MePDJj+V3SuZjwxiY7HTv3m8akeOvYRzHHvHdawCodsLhlYmONCYCJo7K8LkPHLuY4KE4g494c0dQ26QxNG2aDlADjHyLUYJdIE/1qeHmGBm+5UOC9zw==", "bOJZvLp+4vwExezoxZR9no6pIuX+q97Ckhovw8BLjaN3/0waskCOs/gttGsF6fM+Ohyr01HBZv1RKpML5ExJOQ==", "Bob" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemInfo",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupName",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "GroupsInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "GroupName",
                value: "Another Group");
        }
    }
}
