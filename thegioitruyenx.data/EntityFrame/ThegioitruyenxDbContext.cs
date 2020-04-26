using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Configurations;
using thegioitruyenx.data.Entities;

namespace thegioitruyenx.data.EntityFrame
{
    public class ThegioitruyenxDbContext : DbContext
    {
        public ThegioitruyenxDbContext(DbContextOptions options) : base(options)
        {
            //options.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ThegioitruyenxAppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());

            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}
