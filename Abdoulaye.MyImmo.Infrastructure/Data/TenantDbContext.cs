using Abdoulaye.MyImmo.Core.Entities;
using Abdoulaye.MyImmo.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Infrastructure.Data
{
    public class TenantDbContext: DbContext
    {
        public TenantDbContext(DbContextOptions<TenantDbContext> options)
            : base(options)
        {
        }
        public DbSet<TenantEntity> Tenants => Set<TenantEntity>();
        public DbSet<SocieteEntity> Societes => Set<SocieteEntity>();
        public DbSet<AgenceEntity> Agences => Set<AgenceEntity>();
        public DbSet<AgentEntity> Agents => Set<AgentEntity>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TenantEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SocieteEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AgenceEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AgentEntityConfiguration());

            // modelBuilder.ApplyConfigurationsFromAssembly(typeof(TenantDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
