using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace thegioitruyenx.data.EntityFrame
{
    public class ThegioitruyenxContextFactory : IDesignTimeDbContextFactory<ThegioitruyenxDbContext>
    {
        public ThegioitruyenxDbContext CreateDbContext(string[] args)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    //.SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("DBAppSettings")
            //    .Build(); 

            //var connectionString = configuration.GetConnectionString("ThegioitruyenxDatabase");
            var connectionString = "Server=DESKTOP-O7QAEMH;Database=thegioitruyenx;Trusted_Connection=True;";

            var optionsBuilder = new DbContextOptionsBuilder<ThegioitruyenxDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ThegioitruyenxDbContext(optionsBuilder.Options);
        }
    }
}
