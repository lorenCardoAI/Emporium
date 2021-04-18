using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.EntityConfiguration
{
    class LoanRequestEntityConfiguration
       : IEntityTypeConfiguration<LoanRequest>
    {
        public void Configure(EntityTypeBuilder<LoanRequest> loanReqConfig)
        {
            loanReqConfig.ToTable("LoanRequest");
            loanReqConfig.HasKey(cr => cr.LoanRequestId);
            loanReqConfig.Property(cr => cr.SMEId).IsRequired();
            loanReqConfig.Property(cr => cr.FinancingTypeId).IsRequired();
            loanReqConfig.Property(e => e.DateCreated)
                   .HasColumnName("DateCreated")
                   .HasColumnType("datetime2")
                   .HasDefaultValueSql("(sysutcdatetime())");

            loanReqConfig.HasOne(d => d.FinancingType)
                  .WithMany(p => p.LoanRequests)
                  .HasForeignKey(d => d.FinancingTypeId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_LoanRequest_FinancingType_FinancingTypeId");

        }
    }
}
