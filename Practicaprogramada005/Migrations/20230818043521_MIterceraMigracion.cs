using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practicaprogramada005.Migrations
{
    public partial class MIterceraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mecanico",
                table: "Solicitudes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mecanico",
                table: "Solicitudes");
        }
    }
}
