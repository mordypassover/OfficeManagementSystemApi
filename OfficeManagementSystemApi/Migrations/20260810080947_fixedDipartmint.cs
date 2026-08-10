using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeManagementSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class fixedDipartmint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Development",
                table: "Departments",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "Development");
        }
    }
}
