﻿// <auto-generated />
using System;
using CoreAPIBank_0.Models.ContextClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreAPIBank_0.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreAPIBank_0.Models.Entities.UserCardInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CVC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CardLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExpiryMonth")
                        .HasColumnType("int");

                    b.Property<int>("ExpiryYear")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CardInfoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 10000m,
                            CVC = "222",
                            CardLimit = 10000m,
                            CardNumber = "1111 1111 1111 1111",
                            CardUserName = "Test verisidir",
                            CreatedDate = new DateTime(2024, 12, 1, 14, 9, 29, 103, DateTimeKind.Local).AddTicks(492),
                            ExpiryMonth = 12,
                            ExpiryYear = 2025,
                            Status = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
