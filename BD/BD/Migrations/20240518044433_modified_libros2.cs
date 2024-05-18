using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD.Migrations
{
    /// <inheritdoc />
    public partial class modified_libros2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Género",
                table: "Libros",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "Edición",
                table: "Libros",
                newName: "Edicion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Libros",
                newName: "Género");

            migrationBuilder.RenameColumn(
                name: "Edicion",
                table: "Libros",
                newName: "Edición");
        }
    }
}
