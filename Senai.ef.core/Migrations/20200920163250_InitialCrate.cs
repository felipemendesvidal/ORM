using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senai.ef.core.Migrations
{
    public partial class InitialCrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Statu = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    preco = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdPedido = table.Column<Guid>(nullable: false),
                    Pedidoid = table.Column<Guid>(nullable: true),
                    IdProduto = table.Column<Guid>(nullable: false),
                    Produtoid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoItem_Pedido_Pedidoid",
                        column: x => x.Pedidoid,
                        principalTable: "Pedido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoItem_Produto_Produtoid",
                        column: x => x.Produtoid,
                        principalTable: "Produto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoItem_Pedidoid",
                table: "ProdutoItem",
                column: "Pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoItem_Produtoid",
                table: "ProdutoItem",
                column: "Produtoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoItem");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
