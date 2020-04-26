using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using thegioitruyenx.data.Entities;

namespace thegioitruyenx.data.Configurations
{
    public class ThegioitruyenxAppConfigConfiguration : IEntityTypeConfiguration<ThegioitruyenxAppConfig>
    {
        public void Configure(EntityTypeBuilder<ThegioitruyenxAppConfig> builder)
        {
            builder.ToTable("ThegioitruyenxAppConfigs");
            builder.HasKey(x => x.key);
            builder.Property(x => x.value).IsRequired(true);
        }
    }
}
