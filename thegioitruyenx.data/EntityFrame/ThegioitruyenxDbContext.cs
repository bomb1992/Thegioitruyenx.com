using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Entities;

namespace thegioitruyenx.data.EntityFrame
{
    public class ThegioitruyenxDbContext : DbContext
    {
        public ThegioitruyenxDbContext(DbContextOptions options) : base(options)
        {
            //options.UseSqlServer("");
        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}
