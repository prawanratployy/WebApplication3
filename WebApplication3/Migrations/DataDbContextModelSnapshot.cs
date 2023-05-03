﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Database;

#nullable disable

namespace WebApplication3.Migrations
{
    [DbContext(typeof(DataDbContext))]
    partial class DataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication3.model.employee", b =>
                {
                    b.Property<string>("empId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("empName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("hireDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("positionID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("empId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApplication3.model.position", b =>
                {
                    b.Property<string>("positionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<float>("baseSalary")
                        .HasColumnType("float");

                    b.Property<string>("positionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("salaryIncreaseRate")
                        .HasColumnType("float");

                    b.HasKey("positionId");

                    b.ToTable("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}
