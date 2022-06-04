using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class initialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Payments",
                maxLength: 70,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Payments");
        }
    }
}
