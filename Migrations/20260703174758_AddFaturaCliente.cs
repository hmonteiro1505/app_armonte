using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace armonte_aplicacao.Migrations
{
    /// <inheritdoc />
    public partial class AddFaturaCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fatura_Clientes_ClienteId",
                table: "Fatura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fatura",
                table: "Fatura");

            migrationBuilder.RenameTable(
                name: "Fatura",
                newName: "FaturaCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Fatura_ClienteId",
                table: "FaturaCliente",
                newName: "IX_FaturaCliente_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FaturaCliente",
                table: "FaturaCliente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FaturaCliente_Clientes_ClienteId",
                table: "FaturaCliente",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaturaCliente_Clientes_ClienteId",
                table: "FaturaCliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FaturaCliente",
                table: "FaturaCliente");

            migrationBuilder.RenameTable(
                name: "FaturaCliente",
                newName: "Fatura");

            migrationBuilder.RenameIndex(
                name: "IX_FaturaCliente_ClienteId",
                table: "Fatura",
                newName: "IX_Fatura_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fatura",
                table: "Fatura",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fatura_Clientes_ClienteId",
                table: "Fatura",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }
    }
}
