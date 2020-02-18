using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrasilCenter.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Isbn = table.Column<int>(nullable: false),
                    Autor = table.Column<string>(type: "varchar(200)", nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    DtPublicacao = table.Column<DateTime>(nullable: false),
                    Capa = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
