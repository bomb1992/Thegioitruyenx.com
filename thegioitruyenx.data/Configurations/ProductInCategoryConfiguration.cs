using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Entities;

namespace thegioitruyenx.data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<Entities.ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<Entities.ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(t => new {t.CategoryId, t.ProductId});
            builder.HasOne(t => t.Product).WithMany(x => x.ProductInCategories).HasForeignKey(x => x.ProductId);
            builder.HasOne(t => t.Category).WithMany(x => x.ProductInCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}
