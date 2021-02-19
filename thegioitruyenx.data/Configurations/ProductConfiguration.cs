using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Entities;

namespace thegioitruyenx.data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired(true);
            builder.Property(x => x.SeoAlias).IsRequired(false);
            builder.Property(x => x.Stock).IsRequired(true).HasDefaultValue(0);
            builder.Property(x => x.ViewCout).IsRequired(true).HasDefaultValue(0);
        }
    }
}
