using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SeedlingSales.Data;

namespace SeedlingSales.Migrations
{
    [DbContext(typeof(PlantDbContext))]
    [Migration("20170525234429_sales")]
    partial class sales
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

            modelBuilder.Entity("SeedlingSales.Models.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumberSold");

                    b.Property<decimal>("Price");

                    b.Property<int>("SoldPlantID");

                    b.Property<int>("TransactionID");

                    b.HasKey("SaleID");

                    b.HasIndex("SoldPlantID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("SeedlingSales.Models.Sale", b =>
                {
                    b.HasOne("SeedlingSales.Models.Plant", "SoldPlant")
                        .WithMany()
                        .HasForeignKey("SoldPlantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
