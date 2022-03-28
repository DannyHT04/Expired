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
        public DbSet<GroceryModel> GroceryModels { get; set; }
        public DataContext(DbContextOptions options ): base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}