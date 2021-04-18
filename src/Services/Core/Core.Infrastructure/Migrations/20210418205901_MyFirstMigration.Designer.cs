﻿// <auto-generated />
using System;
using Core.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Infrastructure.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20210418205901_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Domain.Entities.FinancingType", b =>
                {
                    b.Property<short>("FinancingTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FinancingTypeId");

                    b.ToTable("FinancingType");
                });

            modelBuilder.Entity("Core.Domain.Entities.LoanRequest", b =>
                {
                    b.Property<long>("LoanRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("DateCreated")
                        .HasDefaultValueSql("(sysutcdatetime())");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<short>("FinancingTypeId")
                        .HasColumnType("smallint");

                    b.Property<bool>("IsBullet")
                        .HasColumnType("bit");

                    b.Property<int>("LoanDuration")
                        .HasColumnType("int");

                    b.Property<decimal>("RequestedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SMEId")
                        .HasColumnType("int");

                    b.HasKey("LoanRequestId");

                    b.HasIndex("FinancingTypeId");

                    b.ToTable("LoanRequest");
                });

            modelBuilder.Entity("Core.Domain.Entities.LoanRequest", b =>
                {
                    b.HasOne("Core.Domain.Entities.FinancingType", "FinancingType")
                        .WithMany("LoanRequests")
                        .HasForeignKey("FinancingTypeId")
                        .HasConstraintName("FK_LoanRequest_FinancingType_FinancingTypeId")
                        .IsRequired();

                    b.Navigation("FinancingType");
                });

            modelBuilder.Entity("Core.Domain.Entities.FinancingType", b =>
                {
                    b.Navigation("LoanRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
