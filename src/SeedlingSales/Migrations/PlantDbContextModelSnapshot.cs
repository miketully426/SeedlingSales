using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SeedlingSales.Data;

namespace SeedlingSales.Migrations
{
    [DbContext(typeof(PlantDbContext))]
    partial class PlantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeedlingSales.Models.Plant", b =>
                {
                    b.Property<int>("PlantID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Ready");

                    b.Property<int>("Seeded");

                    b.HasKey("PlantID");

                    b.ToTable("Plants");
                });
        }
    }
}
