using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.Server.Migrations
{
    public partial class Turo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControlTurnos",
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
                    table.PrimaryKey("PK_ControlTurnos", x => x.Id_Turno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlTurnos");
        }
    }
}
