using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocationMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathToAppartement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Appartements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Appartements");
        }
    }
}
