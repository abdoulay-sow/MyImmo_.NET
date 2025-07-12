using Abdoulaye.MyImmo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Infrastructure.Configurations
{
    public class AgentEntityConfiguration: IEntityTypeConfiguration<AgentEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AgentEntity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nom)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(a => a.Telephone)
                .HasMaxLength(20);
            // Relationships
            builder.HasOne(a => a.Agence)
                .WithMany(ag => ag.Agents)
                .HasForeignKey(a => a.AgenceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
