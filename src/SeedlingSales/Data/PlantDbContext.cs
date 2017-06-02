using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeedlingSales.Models;

namespace SeedlingSales.Data
{
    public class PlantDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public PlantDbContext(DbContextOptions<PlantDbContext> options) : base(options) { }


    }
}
