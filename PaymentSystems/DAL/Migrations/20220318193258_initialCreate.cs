using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BinCode = table.Column<int>(nullable: false),
                    BankCode = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(maxLength: 100, nullable: true),
                    CardType = table.Column<string>(maxLength: 5, nullable: true),
                    Organization = table.Column<string>(maxLength: 50, nullable: true),
                    IsCommercialCard = table.Column<bool>(nullable: false),
                    IsSupportInstallment = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreditCardNumber = table.Column<int>(nullable: false),
                    Owner = table.Column<string>(maxLength: 70, nullable: true),
                    CCV = table.Column<string>(maxLength: 3, nullable: true),
                    CreditCardHolder = table.Column<string>(maxLength: 10, nullable: true),
                    Amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
