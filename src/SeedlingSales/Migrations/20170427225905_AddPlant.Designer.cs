using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SeedlingSales.Data;

namespace SeedlingSales.Migrations
{
    [DbContext(typeof(PlantDbContext))]
    [Migration("20170427225905_AddPlant")]
    partial class AddPlant
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
