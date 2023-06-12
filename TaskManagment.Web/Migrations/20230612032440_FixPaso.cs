using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagment.Web.Migrations
{
    /// <inheritdoc />
    public partial class FixPaso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrdenPaso",
                table: "Pasos",
                newName: "Orden");

            migrationBuilder.RenameColumn(
                name: "DescripcionPaso",
                table: "Pasos",
                newName: "Descripcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Orden",
                table: "Pasos",
                newName: "OrdenPaso");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Pasos",
                newName: "DescripcionPaso");
        }
    }
}
