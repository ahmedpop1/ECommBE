using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceProject.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Registerations_UserName",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Registerations_UserName",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserName",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserName",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Admins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserName",
                table: "Customers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserName",
                table: "Admins",
                column: "UserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Registerations_UserName",
                table: "Admins",
                column: "UserName",
                principalTable: "Registerations",
                principalColumn: "username",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Registerations_UserName",
                table: "Customers",
                column: "UserName",
                principalTable: "Registerations",
                principalColumn: "username",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Registerations_UserName",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Registerations_UserName",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserName",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserName",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Admins",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserName",
                table: "Customers",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserName",
                table: "Admins",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Registerations_UserName",
                table: "Admins",
                column: "UserName",
                principalTable: "Registerations",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Registerations_UserName",
                table: "Customers",
                column: "UserName",
                principalTable: "Registerations",
                principalColumn: "username",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
