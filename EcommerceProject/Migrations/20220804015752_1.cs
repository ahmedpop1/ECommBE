using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceProject.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cartID",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_cartID",
                table: "Customers",
                column: "cartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Carts_cartID",
                table: "Customers",
                column: "cartID",
                principalTable: "Carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Carts_cartID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_cartID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "cartID",
                table: "Customers");
        }
    }
}
