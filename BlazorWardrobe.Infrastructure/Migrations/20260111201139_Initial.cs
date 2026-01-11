using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWardrobe.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GarmentType = table.Column<int>(type: "int", nullable: false),
                    BodyZone = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Season = table.Column<int>(type: "int", nullable: false),
                    LastWornDate = table.Column<DateOnly>(type: "date", nullable: false),
                    WearCount = table.Column<int>(type: "int", nullable: false),
                    IsFavorite = table.Column<bool>(type: "bit", nullable: false),
                    image = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garments", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garments");
        }
    }
}
