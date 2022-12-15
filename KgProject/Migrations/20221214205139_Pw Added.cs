using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KgProject.Migrations
{
    /// <inheritdoc />
    public partial class PwAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pw",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pw",
                table: "Employees");
        }
    }
}
