using Abdoulaye.MyImmo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Infrastructure.Configurations
{
    public class AgenceEntityConfiguration: IEntityTypeConfiguration<AgenceEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AgenceEntity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nom)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(a => a.Adresse)
                .HasMaxLength(250);
            
            // Relationships
            builder.HasOne(a => a.Societe)
                .WithMany(s => s.Agences)
                .HasForeignKey(a => a.SocieteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
