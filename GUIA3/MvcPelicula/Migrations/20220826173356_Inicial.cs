using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcPelicula.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pelicula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lanzamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelicula", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pelicula",
                columns: new[] { "Id", "Genero", "Lanzamiento", "Precio", "Titulo" },
                values: new object[,]
                {
                    { 1, "Accion", new DateTime(2014, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.99m, "John Wick" },
                    { 2, "Accion", new DateTime(2015, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.99m, "John Wick II" },
                    { 3, "Accion", new DateTime(2019, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.99m, "John Wick III" },
                    { 4, "Romance", new DateTime(2012, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.99m, "Votos de Amor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pelicula");
        }
    }
}
