using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWardrobe.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SetDefaultsForGarment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "image",
                table: "Garments",
                newName: "Image");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Garments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Garments",
                newName: "image");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Garments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
