using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagment.Web.Migrations
{
    /// <inheritdoc />
    public partial class FixCargarArchivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TituloArchivoAdjunto",
                table: "ArchivoAdjuntos",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "OrdenArchivoAdjunto",
                table: "ArchivoAdjuntos",
                newName: "Orden");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "ArchivoAdjuntos",
                newName: "TituloArchivoAdjunto");

            migrationBuilder.RenameColumn(
                name: "Orden",
                table: "ArchivoAdjuntos",
                newName: "OrdenArchivoAdjunto");
        }
    }
}
