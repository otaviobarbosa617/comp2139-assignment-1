#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Comp2139_Assignment1.Models;

namespace Comp2139_Assignment1.Data
{
    public class Comp2139_Assignment1Context : DbContext
    {
        public Comp2139_Assignment1Context (DbContextOptions<Comp2139_Assignment1Context> options)
            : base(options)
        {
        }

        public DbSet<Comp2139_Assignment1.Models.Customers> Customers { get; set; }

        public DbSet<Comp2139_Assignment1.Models.Technicians> Technicians { get; set; }
    }
}
