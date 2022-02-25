﻿// <auto-generated />
using System;
using Comp2139_Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Comp2139_Assignment1.Migrations
{
    [DbContext(typeof(Comp2139_Assignment1Context))]
    [Migration("20220225003910_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Comp2139_Assignment1.Models.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CustomerAddress = "Test Street",
                            CustomerCity = "Toronto",
                            CustomerCountry = "Canada",
                            CustomerEmail = "janine.maeusana@georgebrown.ca",
                            CustomerFirstName = "Janine",
                            CustomerLastName = "Usana",
                            CustomerPhone = "666-666-6666",
                            CustomerState = "Ontario"
                        },
                        new
                        {
                            CustomerId = 2,
                            CustomerAddress = "Test Avenue",
                            CustomerCity = "New York",
                            CustomerCountry = "USA",
                            CustomerEmail = "omar.nabi@georgebrown.ca",
                            CustomerFirstName = "Omar",
                            CustomerLastName = "Nabi",
                            CustomerPhone = "666-666-6666",
                            CustomerState = "NY"
                        });
                });

            modelBuilder.Entity("Comp2139_Assignment1.Models.Incident", b =>
                {
                    b.Property<int>("IncidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncidentId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("IncidentDateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IncidentDateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("IncidentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncidentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TechId")
                        .HasColumnType("int");

                    b.Property<int?>("TechnicianTecId")
                        .HasColumnType("int");

                    b.HasKey("IncidentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TechnicianTecId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            IncidentId = 1,
                            CustomerId = 1,
                            IncidentDateOpened = new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            IncidentDescription = "Create separated logins for users and admins",
                            IncidentTitle = "Fix Login",
                            ProductId = 1,
                            TechId = 0
                        },
                        new
                        {
                            IncidentId = 2,
                            CustomerId = 2,
                            IncidentDateOpened = new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            IncidentDescription = "Updated the whole visual",
                            IncidentTitle = "Change overall theme",
                            ProductId = 1,
                            TechId = 0
                        });
                });

            modelBuilder.Entity("Comp2139_Assignment1.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductCode = "1Sport",
                            ProductName = "Sport One - Team Management",
                            ProductPrice = "29.99",
                            ProductReleaseDate = new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("Comp2139_Assignment1.Models.Technicians", b =>
                {
                    b.Property<int>("TecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TecId"), 1L, 1);

                    b.Property<string>("TecEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TecName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TecPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TecId");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            TecId = 1,
                            TecEmail = "otavio.pereirabarbosa@georgebrown.ca",
                            TecName = "Otavio Barbosa",
                            TecPhone = "647-562-3407"
                        });
                });

            modelBuilder.Entity("Comp2139_Assignment1.Models.Incident", b =>
                {
                    b.HasOne("Comp2139_Assignment1.Models.Customers", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Comp2139_Assignment1.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Comp2139_Assignment1.Models.Technicians", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianTecId");

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Technician");
                });
#pragma warning restore 612, 618
        }
    }
}
