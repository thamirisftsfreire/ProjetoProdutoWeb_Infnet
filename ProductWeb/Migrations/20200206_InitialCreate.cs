using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Int32>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Fabricante = table.Column<string>(nullable: false),
                    CodigoBarras = table.Column<string>(nullable: false),
                    Preco = table.Column<Decimal>(nullable: false),
                    Estoque = table.Column<Int32>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Produtos", x => x.Id); });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Id",
                table: "Produtos",
                column: "Id");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
