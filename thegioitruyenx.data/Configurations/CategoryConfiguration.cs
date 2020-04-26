using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Entities;
using thegioitruyenx.data.Enums;

namespace thegioitruyenx.data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).IsRequired(true).HasDefaultValue(Status.Active);
            builder.Property(x => x.SortOder).IsRequired(true);
        }
    }
}
