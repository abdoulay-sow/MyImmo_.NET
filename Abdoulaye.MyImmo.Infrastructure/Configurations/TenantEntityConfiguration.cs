using Abdoulaye.MyImmo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Infrastructure.Configurations
{
    public class TenantEntityConfiguration: IEntityTypeConfiguration<TenantEntity>
    {
        public void Configure(EntityTypeBuilder<TenantEntity> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
            builder.Property(t => t.ConnectionString).IsRequired().HasMaxLength(500);
        }
    }
}
