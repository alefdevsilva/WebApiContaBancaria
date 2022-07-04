using Microsoft.EntityFrameworkCore.Migrations;

namespace ContaBancaria.Infra.Migrations
{
    public partial class CriandoatabelaContaPoupanca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConstasPoupanca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDaconta = table.Column<int>(nullable: false),
                    Saldo = table.Column<double>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstasPoupanca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConstasPoupanca_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConstasPoupanca_ClienteId",
                table: "ConstasPoupanca",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstasPoupanca");
        }
    }
}
