using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Infrastructure.EntityConfiguration
{
    class FinancingTypeEntityConfiguration
         : IEntityTypeConfiguration<FinancingType>
    {
        public void Configure(EntityTypeBuilder<FinancingType> finTypeConfig)
        {
            finTypeConfig.ToTable("FinancingType");
            finTypeConfig.HasKey(cr => cr.FinancingTypeId);
            finTypeConfig.Property(cr => cr.Name).IsRequired()
                    .HasMaxLength(100);     
        }
    }
}
