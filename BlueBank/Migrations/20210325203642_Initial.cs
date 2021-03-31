using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueBank.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTitular = table.Column<string>(type: "varchar(100)", nullable: false),
                    valorInicial = table.Column<int>(nullable: false),
                    saldo = table.Column<int>(nullable: false),
                    valorConsignar = table.Column<int>(nullable: false),
                    valorRetirar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuenta");
        }
    }
}
