using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.Server.Migrations
{
    public partial class Tuns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peluquerosdb",
                columns: table => new
                {
                    Id_Peluquero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peluquero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dia_Y_Horario_Disponible = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peluquerosdb", x => x.Id_Peluquero);
                });

            migrationBuilder.CreateTable(
                name: "Productosdb",
                columns: table => new
                {
                    Id_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productosdb", x => x.Id_Producto);
                });

            migrationBuilder.CreateTable(
                name: "Serviciosdb",
                columns: table => new
                {
                    Id_Servicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Servicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Productos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tiempo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serviciosdb", x => x.Id_Servicio);
                });

            migrationBuilder.CreateTable(
                name: "Turnosdb",
                columns: table => new
                {
                    Id_Turno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nº_Turno = table.Column<int>(type: "int", nullable: false),
                    Nick = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peluquero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Servicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dia_Y_Hora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnosdb", x => x.Id_Turno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peluquerosdb");

            migrationBuilder.DropTable(
                name: "Productosdb");

            migrationBuilder.DropTable(
                name: "Serviciosdb");

            migrationBuilder.DropTable(
                name: "Turnosdb");
        }
    }
}
