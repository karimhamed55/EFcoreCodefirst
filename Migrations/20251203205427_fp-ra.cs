using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    /// <inheritdoc />
    public partial class fpra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesBooks_Books_bookid",
                table: "EmployeesBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesBooks_Employees_employeeid",
                table: "EmployeesBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Customers_customer_id1",
                table: "Orderss");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesBooks_Books_bookid",
                table: "EmployeesBooks",
                column: "bookid",
                principalTable: "Books",
                principalColumn: "Bookid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesBooks_Employees_employeeid",
                table: "EmployeesBooks",
                column: "employeeid",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Customers_customer_id1",
                table: "Orderss",
                column: "customer_id1",
                principalTable: "Customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesBooks_Books_bookid",
                table: "EmployeesBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesBooks_Employees_employeeid",
                table: "EmployeesBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderss_Customers_customer_id1",
                table: "Orderss");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesBooks_Books_bookid",
                table: "EmployeesBooks",
                column: "bookid",
                principalTable: "Books",
                principalColumn: "Bookid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesBooks_Employees_employeeid",
                table: "EmployeesBooks",
                column: "employeeid",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderss_Customers_customer_id1",
                table: "Orderss",
                column: "customer_id1",
                principalTable: "Customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
