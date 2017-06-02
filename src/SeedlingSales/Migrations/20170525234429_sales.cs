using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SeedlingSales.Migrations
{
    public partial class sales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumberSold = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    SoldPlantID = table.Column<int>(nullable: false),
                    TransactionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleID);
                    table.ForeignKey(
                        name: "FK_Sales_Plants_SoldPlantID",
                        column: x => x.SoldPlantID,
                        principalTable: "Plants",
                        principalColumn: "PlantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SoldPlantID",
                table: "Sales",
                column: "SoldPlantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
