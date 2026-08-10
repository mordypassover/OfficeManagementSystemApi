using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeManagementSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class fixedEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DepartmintId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "DepartmintId",
                table: "Projects",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_DepartmintId",
                table: "Projects",
                newName: "IX_Projects_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Salart",
                table: "Employees",
                newName: "Salary");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DepartmentId",
                table: "Projects",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DepartmentId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Projects",
                newName: "DepartmintId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_DepartmentId",
                table: "Projects",
                newName: "IX_Projects_DepartmintId");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employees",
                newName: "Salart");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DepartmintId",
                table: "Projects",
                column: "DepartmintId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
