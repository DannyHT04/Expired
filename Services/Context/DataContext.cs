using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expired.Models;
using Microsoft.EntityFrameworkCore;


namespace Expired.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<UserModel> UserInfo { get; set; }
        public DbSet<ItemModel> ItemInfo { get; set; }
        public DbSet<GroupModel> GroupsInfo { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }
        private void SeedData(ModelBuilder builder)
        {
            var defaultData = new List<GroupModel>()
            {
                new GroupModel(){
                    Id = 1,
                    GroupName = "Group 1",
                    GroupPassword = "123",
                    IsGroupDeleted = false
                },
                new GroupModel(){
                    Id = 2,
                    GroupName = "Group 2",
                    GroupPassword = "321",
                    IsGroupDeleted = false
                },
                new GroupModel(){
                    Id = 3,
                    GroupName = "Group 3",
                    GroupPassword = "ILovePanCakes",
                    IsGroupDeleted = false
                }
            };
            builder.Entity<GroupModel>().HasData(defaultData);

            var UserData = new List<UserModel>()
            {
                new UserModel(){
                    Id = 1,
                    GroupId = 1,
                    Username = "Danny",
                    Salt = "f3Kf9IhMiDpJXfLDGc7DM9n4lhyYUYXfQvhAROUHn5gw/fiYBL6OFZQ8t2OfutqmwQsGeD9dwgjh6MvUsBvqJA==",
                    Hash = "949Ebs/nVwzi08Vdz7cZI28dbz4hHlyW93SXUWdcBWU4STLeFIgfOi/LXQNkb/mPi2LuRDwmEk7wEBVOvTS7FzS7n/qQyiw+zv1QQcOKMmzph30AFzUwltFJ69ahWEFslZw/NCV2GudMCHYFBqis3vllQokaEHo19sbzMqD3tU873JuQrCzJxXb0OdngKeJT5/jLddriZXToNsE5GTumrnnQOnG6P290eDd0VJHgCurjKzlchaNKzMYsotYgLmj3hrQIJKt0njjcEqsDtm6m+cFsJ9M5vY4INI0YKVOx5dQBuXC/spKNgDbx8x4g1xSzHtTTKwel1a94Yp0KfEkTBg==",
                    DeleteUser = false
                },
                new UserModel(){
                    Id = 2,
                    GroupId = 0,
                    Username = "Jovann",
                    Salt = "PiLgqPNAW96VxCyUSVX7KMQWHDS8bFX9PbMG8QgV3pn+A+ITCYaLo3M5yw5ShKdORqP5R9/fQTP0WNL6X1D96Q==",
                    Hash = "SGJyUcgn2+R6+76gXMiGXBJhSh4jNt/b/GF5DEekKkUxMfxpCpO5zVTJLCLk176rW8+Ph5pYz/D1TERfEDgPv6haP78Ogj3DTG2GiT9QdZv9RBAmQqPUBKe/OjOWBDlm6Y49ITOxLiHFXBDV5jxyOfMEhMjlT1Gy99a3jfckkMjFwFjMLCvBXEFyoPLYCMlJbVcNyVtyVo8lkftndoProogigDa5atoNr8RqdoLRQ3/6zhI8zvo6rNMJ5wr96uv0dGmH6TUk48Bqomu923HcavY0YBJ1xL8f1Hne214EDbAmPUxACpVLuhTdviPefb+FHcQ9H8SrvuyaQwGe/CkEkA==",
                    DeleteUser = false
                },
                new UserModel(){
                    Id = 3,
                    GroupId = 1,
                    Username = "Trent",
                    Salt = "2DxKtfn6ksuh64AaVURKyOGTuPtCsaURi2DpIDZugt/oRWuQfqMNpODbbJR+dCECzkahus/iQnReNxHPx6Wwpw==",
                    Hash = "gOsplAgVxvbNR/w/KO4kzFVHjbQ8CaMCSs04v0QDK7hDe+szWMykqlqdEWKky4HXOhZobZWSEmFH7NMuimKMrx1OClQD6g0XIh6CK8+Ai6ZRtOo7I8ZJbtwRi9Kj+9ee44V8DZhvbRrFh2E25ooQSgF3EP+h1CmUQMVnPqAvV6Evo7lWj+s/Z2GquauBn+H2tDNQekTlaSmta97uOlKE73skCqsZmlDAQNFNDlCOarNN+1x3njSXhEHL1u9CoTyHTwlE6WDMMIUqS6ksWiUNWvwld3UXiIUAyqmrxI692jhs46w9R64cpiZ/sB0RfK88YB4w1/PlILAJcSbNNWoZUg==",
                    DeleteUser = false
                },
                new UserModel(){
                    Id = 4,
                    GroupId = 2,
                    Username = "Billy",
                    Salt = "xKJOIM0ZBtosw7Wmcjc7ZLLO7cOvFZbFxzD3u696PMkCUiDqcj4Ws9pDJVZXtvdo8GnGSH+WEeZFJRryjUy1yQ==",
                    Hash = "CRJLCq7aB48R4+fMkt76lrn0g6fBfgIjXu5p5CUoIK0/sEU+bFjw1A2y895HznAOuxdHlbaauCcqs/a6nYRoX5dro6pulsEWXXUuSNwuoTBUcnkjaQPljj5/SBiTuZX3IKxcdZVJlfFiOW1veZPPOYLI5G5bKnZnGFQ76xEw6KJLWxmLnXHmyjwZPm3jHTVWuOF6jFf+D8Tzo49Hk47tDOg4BzKk0L/HStJlrxicWSBy+g2brAPAypkd0e6wjQgGPlJWQp+5mYRaQW0Z+rrFxVyvkIZ03k6ObEnUevXci82rAQgmeBqvMOMGsrlWX65mCAxX0S4JOR6NeOORSTP/aw==",
                    DeleteUser = false
                },
                new UserModel(){
                    Id = 5,
                    GroupId = 3,
                    Username = "Bob",
                    Salt = "bOJZvLp+4vwExezoxZR9no6pIuX+q97Ckhovw8BLjaN3/0waskCOs/gttGsF6fM+Ohyr01HBZv1RKpML5ExJOQ==",
                    Hash = "vvWpOiwl8uuKV9tWFs8mSnyM0xbzAosalTZa2c3FTrXFWRKmaPPb48/YREIT/jVpfgMvjfrG70hxi/buJInFJufKdiBPsRxqRnkImRPFvg7SF+5TAfKWCL1jXpeB3+EsQ3EIi0fD+nYdr6Gn1M+lo1gQp6L/0DnMR/uI1pykdWbOS9/f5Bxj1E7FPlQhkSsHPmYsOczoWOmea8/y3yxKcKWNoZarrxfLe4MePDJj+V3SuZjwxiY7HTv3m8akeOvYRzHHvHdawCodsLhlYmONCYCJo7K8LkPHLuY4KE4g494c0dQ26QxNG2aDlADjHyLUYJdIE/1qeHmGBm+5UOC9zw==",
                    DeleteUser = false
                },
            };
            builder.Entity<UserModel>().HasData(UserData);

            var ItemData = new List<ItemModel>()
            {
                new ItemModel(){

                    Id = 1,
                    UserId = 1,
                    GroupId = 1,
                    ProductName = "Milk",
                    DateOfExpiration = "04-13-2022",
                    Owner = "Danny",
                    ProductImage = "I am a string of a png",
                    Category = "Dairy",
                    isGroceryList = true,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 2,
                    UserId = 1,
                    GroupId = 1,
                    ProductName = "Bread",
                    DateOfExpiration = "04-15-2022",
                    Owner = "Danny",
                    ProductImage = "I am a string of a png",
                    Category = "Food",
                    isGroceryList = false,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 3,
                    UserId = 2,
                    GroupId = 0,
                    ProductName = "Pepsi",
                    DateOfExpiration = "06-13-2023",
                    Owner = "Jovann",
                    ProductImage = "I am a string of a png",
                    Category = "Drink",
                    isGroceryList = true,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 4,
                    UserId = 2,
                    GroupId = 0,
                    ProductName = "Milk",
                    DateOfExpiration = "04-27-2022",
                    Owner = "Jovann",
                    ProductImage = "I am a string of a png",
                    Category = "Dairy",
                    isGroceryList = false,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 5,
                    UserId = 3,
                    GroupId = 1,
                    ProductName = "Eggs",
                    DateOfExpiration = "06-13-2022",
                    Owner = "Trent",
                    ProductImage = "I am a string of a png",
                    Category = "Food",
                    isGroceryList = true,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 6,
                    UserId = 3,
                    GroupId = 1,
                    ProductName = "Steak",
                    DateOfExpiration = "04-26-2022",
                    Owner = "Trent",
                    ProductImage = "I am a string of a png",
                    Category = "Food",
                    isGroceryList = false,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 7,
                    UserId = 4,
                    GroupId = 2,
                    ProductName = "Steak",
                    DateOfExpiration = "04-27-2022",
                    Owner = "Billy",
                    ProductImage = "I am a string of a png",
                    Category = "Food",
                    isGroceryList = true,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 8,
                    UserId = 4,
                    GroupId = 2,
                    ProductName = "Bacon",
                    DateOfExpiration = "04-27-2022",
                    Owner = "Billy",
                    ProductImage = "I am a string of a png",
                    Category = "Food",
                    isGroceryList = true,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 9,
                    UserId = 5,
                    GroupId = 3,
                    ProductName = "Kimchi",
                    DateOfExpiration = "07-26-2023",
                    Owner = "Bob",
                    ProductImage = "I am a string of a png",
                    Category = "Food",
                    isGroceryList = false,
                    isDeleted = false
                },
                new ItemModel(){

                    Id = 10,
                    UserId = 5,
                    GroupId = 3,
                    ProductName = "Ranch",
                    DateOfExpiration = "04-02-2022",
                    Owner = "Bob",
                    ProductImage = "I am a string of a png",
                    Category = "Food",
                    isGroceryList = false,
                    isDeleted = false
                },
            };
            builder.Entity<ItemModel>().HasData(ItemData);



        }
    }
}