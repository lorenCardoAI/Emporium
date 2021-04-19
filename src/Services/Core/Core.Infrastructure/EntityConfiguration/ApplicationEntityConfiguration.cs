using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.EntityConfiguration
{
    class ApplicationEntityConfiguration
       : IEntityTypeConfiguration<Domain.Entities.Application>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Application> appConfig)
        {
            appConfig.ToTable("Application");
            appConfig.Property(e => e.Id)
                   .HasColumnName("ApplicationId");
            appConfig.HasKey(e => e.Id);

            appConfig.Property(e => e.SMEId).IsRequired();
            appConfig.Property(e => e.ProductId).IsRequired();
            appConfig.Property(e => e.ApplicationStatusId).IsRequired();
            appConfig.Property(e => e.DateCreated)
                   .HasColumnName("DateCreated")
                   .HasColumnType("datetime2")
                   .HasDefaultValueSql("(sysutcdatetime())");

            appConfig.HasOne(d => d.ApplicationStatus)
                  .WithMany(p => p.Applications)
                  .HasForeignKey(d => d.ApplicationStatusId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Application_ApplicationStatus_ApplicationStatusId");

        }
    }
}
