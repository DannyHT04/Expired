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
        public DataContext(DbContextOptions options ): base(options)
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
                    GroupName = "Test",
                    GroupPassword = "123",
                    IsGroupDeleted = false
                },
                new GroupModel(){
                    Id = 2,
                    GroupName = "Another Group",
                    GroupPassword = "321",
                    IsGroupDeleted = false
                }
            };
            builder.Entity<GroupModel>().HasData(defaultData);
        }
    }
}