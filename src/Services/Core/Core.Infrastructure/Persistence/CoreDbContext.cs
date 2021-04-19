using Entities = Core.Domain.Entities;
using Core.Infrastructure.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Persistence
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {
        }

        public DbSet<Entities.Application> Applications { get; set; }
        public DbSet<Entities.ApplicationStatus> ApplicationStatuses { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationEntityConfiguration());
            builder.ApplyConfiguration(new ApplicationStatusEntityConfiguration());
        }
    }
}
