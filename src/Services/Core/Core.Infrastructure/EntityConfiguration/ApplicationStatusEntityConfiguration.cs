using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Infrastructure.EntityConfiguration
{
    class ApplicationStatusEntityConfiguration
         : IEntityTypeConfiguration<ApplicationStatus>
    {
        public void Configure(EntityTypeBuilder<ApplicationStatus> appStatusConf)
        {
            appStatusConf.ToTable("ApplicationStatus");
            appStatusConf.Property(e => e.Id)
                             .HasColumnName("Id");

            appStatusConf.HasKey(e => e.Id);

            appStatusConf.Property(e => e.Name).IsRequired()
                      .HasMaxLength(100);

            appStatusConf.Property(e => e.ReferenceId).IsRequired().HasColumnName("ReferenceId");

            appStatusConf.Property(e => e.DateCreated)
                      .HasColumnName("DateCreated")
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("(sysutcdatetime())");
        }
    }
}
