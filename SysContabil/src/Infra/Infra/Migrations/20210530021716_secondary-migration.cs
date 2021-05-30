using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class secondarymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanoDeContas",
                columns: table => new
                {
                    NumeroDaConta = table.Column<string>(type: "varchar(12)", nullable: false),
                    NomeDaConta = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDeContas", x => x.NumeroDaConta);
                });

            migrationBuilder.CreateTable(
                name: "Lancamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPlanoDeConta = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(type: "DATE", nullable: false),
                    Debito = table.Column<string>(type: "varchar(12)", nullable: false),
                    Credito = table.Column<string>(type: "varchar(12)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal", nullable: false),
                    PlanoDeContaNumeroDaConta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lancamentos_PlanoDeContas_PlanoDeContaNumeroDaConta",
                        column: x => x.PlanoDeContaNumeroDaConta,
                        principalTable: "PlanoDeContas",
                        principalColumn: "NumeroDaConta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_PlanoDeContaNumeroDaConta",
                table: "Lancamentos",
                column: "PlanoDeContaNumeroDaConta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");

            migrationBuilder.DropTable(
                name: "PlanoDeContas");
        }
    }
}
