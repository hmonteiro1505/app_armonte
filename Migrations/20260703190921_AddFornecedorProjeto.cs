using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace armonte_aplicacao.Migrations
{
    /// <inheritdoc />
    public partial class AddFornecedorProjeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_ProjetoObraRelacaoCustos_ProjetoObraRelacaoCustosId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedores_ProjetoObraRelacaoCustosId",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "ProjetoObraRelacaoCustosId",
                table: "Fornecedores");

            migrationBuilder.AddColumn<int>(
                name: "ProjetoId",
                table: "Fornecedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_ProjetoId",
                table: "Fornecedores",
                column: "ProjetoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_ProjetoObraRelacaoCustos_ProjetoId",
                table: "Fornecedores",
                column: "ProjetoId",
                principalTable: "ProjetoObraRelacaoCustos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_ProjetoObraRelacaoCustos_ProjetoId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedores_ProjetoId",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "ProjetoId",
                table: "Fornecedores");

            migrationBuilder.AddColumn<int>(
                name: "ProjetoObraRelacaoCustosId",
                table: "Fornecedores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_ProjetoObraRelacaoCustosId",
                table: "Fornecedores",
                column: "ProjetoObraRelacaoCustosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_ProjetoObraRelacaoCustos_ProjetoObraRelacaoCustosId",
                table: "Fornecedores",
                column: "ProjetoObraRelacaoCustosId",
                principalTable: "ProjetoObraRelacaoCustos",
                principalColumn: "Id");
        }
    }
}
