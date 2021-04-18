using Core.Domain.Entities;
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

        public DbSet<LoanRequest> LoanRequests { get; set; }
        public DbSet<FinancingType> FinancingTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new LoanRequestEntityConfiguration());
            builder.ApplyConfiguration(new FinancingTypeEntityConfiguration());
        }
    }
}
