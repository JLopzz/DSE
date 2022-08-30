using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcPelicula.Migrations
{
    public partial class Calificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Calificacion",
                table: "Pelicula",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
            migrationBuilder.UpdateData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 1,
                column: "Calificacion",
                value: "D");
            migrationBuilder.UpdateData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 2,
                column: "Calificacion",
                value: "D");
            migrationBuilder.UpdateData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 3,
                column: "Calificacion",
                value: "D");
            migrationBuilder.UpdateData(
                table: "Pelicula",
                keyColumn: "Id",
                keyValue: 4,
                column: "Calificacion",
                value: "A");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calificacion",
                table: "Pelicula");
        }
    }
}
