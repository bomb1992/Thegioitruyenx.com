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

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("DBAppSettings.json")
                .Build();

            var strcon = configuration.GetConnectionString("ThegioitruyenxDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<ThegioitruyenxDbContext>();
            optionsBuilder.UseSqlServer(strcon);

            return new ThegioitruyenxDbContext(optionsBuilder.Options);
        }
    }
}
