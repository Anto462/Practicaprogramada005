using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practicaprogramada005.Migrations
{
    public partial class MIPrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Resindencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    ServiciosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Costo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Servicio__ED7749BA09E86233", x => x.ServiciosID);
                });

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    SolicitudesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiciosID = table.Column<int>(type: "int", nullable: false),
                    IDUSUARIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Datsauto1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Datsauto2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Datsauto3 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Datsauto4 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    estadode = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Solicitu__75DF73DD07EC6F2C", x => x.SolicitudesID);
                    table.ForeignKey(
                        name: "FK__Solicitud__Servi__4BAC3F29",
                        column: x => x.ServiciosID,
                        principalTable: "Servicios",
                        principalColumn: "ServiciosID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_ServiciosID",
                table: "Solicitudes",
                column: "ServiciosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Servicios");
        }
    }
}
