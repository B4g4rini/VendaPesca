using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendaPesca.Data.Migrations
{
    /// <inheritdoc />
    public partial class novo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Produto_ProdutosProdutoId",
                table: "Venda");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProdutosProdutoId",
                table: "Venda",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "Produto",
                table: "Venda",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Produto_ProdutosProdutoId",
                table: "Venda",
                column: "ProdutosProdutoId",
                principalTable: "Produto",
                principalColumn: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Produto_ProdutosProdutoId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "Produto",
                table: "Venda");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProdutosProdutoId",
                table: "Venda",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Produto_ProdutosProdutoId",
                table: "Venda",
                column: "ProdutosProdutoId",
                principalTable: "Produto",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
