﻿using Microsoft.EntityFrameworkCore;

namespace Comp2139_Assignment1.Models
{
    public class Comp2139_Assignment1Context : DbContext
    {
        public Comp2139_Assignment1Context(DbContextOptions<Comp2139_Assignment1Context> options)
            : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Technicians> Technicians { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>().HasData(
                new Customers
                {
                    CustomerId = 1,
                    CustomerFirstName = "Janine",
                    CustomerLastName = "Usana",
                    CustomerAddress = "Test Street",
                    CustomerCity = "Toronto",
                    CustomerState = "Ontario",
                    CustomerCountry = "Canada",
                    CustomerEmail = "janine.maeusana@georgebrown.ca",
                    CustomerPhone = "666-666-6666",
                },
                new Customers
                {
                    CustomerId = 2,
                    CustomerFirstName = "Omar",
                    CustomerLastName = "Nabi",
                    CustomerAddress = "Test Avenue",
                    CustomerCity = "New York",
                    CustomerState = "NY",
                    CustomerCountry = "USA",
                    CustomerEmail = "omar.nabi@georgebrown.ca",
                    CustomerPhone = "666-666-6666",
                }

            );

            modelBuilder.Entity<Technicians>().HasData(
                new Technicians
                {
                    TecId = 1,
                    TecName = "Otavio Barbosa",
                    TecEmail = "otavio.pereirabarbosa@georgebrown.ca",
                    TecPhone = "647-562-3407"
                }
            );

            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    ProductId = 1,
                    ProductCode = "1Sport",
                    ProductName = "Sport One - Team Management",
                    ProductPrice = "29.99",
                    ProductReleaseDate = DateTime.Today
                }
            );

            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    IncidentId = 1,
                    CustomerId = 1,
                    ProductId = 1,
                    IncidentTitle = "Fix Login",
                    IncidentDescription = "Create separated logins for users and admins",
                    IncidentDateOpened = DateTime.Today
                },
                new Incident
                {
                    IncidentId = 2,
                    CustomerId = 2,
                    ProductId = 1,
                    IncidentTitle = "Change overall theme",
                    IncidentDescription = "Updated the whole visual",
                    IncidentDateOpened = DateTime.Today
                }
            );
        }

    }
}