using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcPelicula.Migrations
{
    public partial class Director : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Productor",
                table: "Pelicula",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPelicula = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                    table.ForeignKey("FK_Peliculca_Director", x => x.IdPelicula, "Pelicula");
                });
            migrationBuilder.UpdateData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 1,
                column: "Productor",
                value: "Basil Iwanyk");
            migrationBuilder.UpdateData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 2,
                column: "Productor",
                value: "David Leitch");
            migrationBuilder.UpdateData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 3,
                column: "Productor",
                value: "Erica Lee");
            migrationBuilder.UpdateData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 4,
                column: "Productor",
                value: "Jonathan Glickman");

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "IdPelicula", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Chad Stahelski" },
                    { 2, 2, "Chad Stahelski" },
                    { 3, 3, "Chad Stahelski" },
                    { 4, 4, "Michael Sucsy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropColumn(
                name: "Productor",
                table: "Pelicula");
        }
    }
}
