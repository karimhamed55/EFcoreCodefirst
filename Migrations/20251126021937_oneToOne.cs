using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    /// <inheritdoc />
    public partial class oneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_depid",
                table: "Employees",
                column: "depid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_depid",
                table: "Employees",
                column: "depid",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_depid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_depid",
                table: "Employees");
        }
    }
}
