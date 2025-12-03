using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    /// <inheritdoc />
    public partial class refrentialactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Orderss",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: true),
                    customer_id1 = table.Column<int>(type: "int", nullable: false,
                    defaultValue: 1)
               
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderss", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_Orderss_Customers_customer_id1",
                        column: x => x.customer_id1,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.SetDefault
                        );
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orderss_customer_id1",
                table: "Orderss",
                column: "customer_id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orderss");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
