using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace armonte_aplicacao.Migrations
{
    /// <inheritdoc />
    public partial class AddProjetoObraRelacaoCustos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjetoId",
                table: "Obras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjetoObraRelacaoCustosId",
                table: "Fornecedores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjetoObraRelacaoCustosId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjetoObraRelacaoCustos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoRegularizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InicioObra = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjetoObraRelacaoCustos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Obras_ProjetoId",
                table: "Obras",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_ProjetoObraRelacaoCustosId",
                table: "Fornecedores",
                column: "ProjetoObraRelacaoCustosId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ProjetoObraRelacaoCustosId",
                table: "Clientes",
                column: "ProjetoObraRelacaoCustosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_ProjetoObraRelacaoCustos_ProjetoObraRelacaoCustosId",
                table: "Clientes",
                column: "ProjetoObraRelacaoCustosId",
                principalTable: "ProjetoObraRelacaoCustos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_ProjetoObraRelacaoCustos_ProjetoObraRelacaoCustosId",
                table: "Fornecedores",
                column: "ProjetoObraRelacaoCustosId",
                principalTable: "ProjetoObraRelacaoCustos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Obras_ProjetoObraRelacaoCustos_ProjetoId",
                table: "Obras",
                column: "ProjetoId",
                principalTable: "ProjetoObraRelacaoCustos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_ProjetoObraRelacaoCustos_ProjetoObraRelacaoCustosId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_ProjetoObraRelacaoCustos_ProjetoObraRelacaoCustosId",
                table: "Fornecedores");

            migrationBuilder.DropForeignKey(
                name: "FK_Obras_ProjetoObraRelacaoCustos_ProjetoId",
                table: "Obras");

            migrationBuilder.DropTable(
                name: "ProjetoObraRelacaoCustos");

            migrationBuilder.DropIndex(
                name: "IX_Obras_ProjetoId",
                table: "Obras");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedores_ProjetoObraRelacaoCustosId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ProjetoObraRelacaoCustosId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ProjetoId",
                table: "Obras");

            migrationBuilder.DropColumn(
                name: "ProjetoObraRelacaoCustosId",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "ProjetoObraRelacaoCustosId",
                table: "Clientes");
        }
    }
}
