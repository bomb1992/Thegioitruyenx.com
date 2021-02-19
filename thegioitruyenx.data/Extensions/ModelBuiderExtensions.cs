using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Entities;
using thegioitruyenx.data.Enums;

namespace thegioitruyenx.data.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seeding Data
            modelBuilder.Entity<ThegioitruyenxAppConfig>().HasData(new ThegioitruyenxAppConfig { Key = "HomeTitle", Value = "This is home page of thegioitruyenx.com" },
                new ThegioitruyenxAppConfig { Key = "HomeKeywork", Value = "This is keywork page of thegioitruyenx.com" },
                new ThegioitruyenxAppConfig { Key = "HomeDescription", Value = "This is description of thegioitruyenx.com" }
               );

            modelBuilder.Entity<Category>().HasData(
                new Category { Name = "Áo",IsShowOnHome = true, ParentId = null, SortOder = 1, Status = Status.Active },
                new Category { Name = "Quần", IsShowOnHome = true, ParentId = null, SortOder = 1, Status = Status.Active },
                new Category { Name = "Giày", IsShowOnHome = true, ParentId = null, SortOder = 1, Status = Status.Active }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Name = "Áo thun", Price = 10000, OriginalPrice = 7000, Stock = 10, ViewCout = 0 },
                new Product { Name = "Quần thun", Price = 20000, OriginalPrice = 15000, Stock = 20, ViewCout = 0 },
                new Product { Name = "Quần Tây", Price = 30000, OriginalPrice = 20000, Stock = 20, ViewCout = 0 }
                );
        }
    }
}
