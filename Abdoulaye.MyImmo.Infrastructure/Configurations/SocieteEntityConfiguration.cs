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
    internal class SocieteEntityConfiguration: IEntityTypeConfiguration<SocieteEntity>
    {
        public void Configure(EntityTypeBuilder<SocieteEntity> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Nom)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(s => s.Adresse)
                .HasMaxLength(250);

            builder.HasMany(s => s.Agences)
                .WithOne(a => a.Societe)
                .HasForeignKey(a => a.SocieteId);
        }
    }
}
