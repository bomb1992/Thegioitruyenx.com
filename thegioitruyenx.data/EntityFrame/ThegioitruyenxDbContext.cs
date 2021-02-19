﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Configurations;
using thegioitruyenx.data.Entities;
using thegioitruyenx.data.Extensions;

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
            // Configure using Fluent API
            modelBuilder.ApplyConfiguration(new ThegioitruyenxAppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());

            //Data seeding
            modelBuilder.thegioitruyenSeed();

            //IRIS
        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<ProductInCategory> ProductInCategorys { set; get; }
        public DbSet<ThegioitruyenxAppConfig> ThegioitruyenxAppConfigs { set; get; }
    }
}
