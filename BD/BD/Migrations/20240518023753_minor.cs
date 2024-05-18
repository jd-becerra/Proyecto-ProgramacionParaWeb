using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD.Migrations
{
    /// <inheritdoc />
    public partial class minor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multas_Prestamos_PrestamoId",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "FechaPréstamo",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "FechaCreación",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "PréstamoId",
                table: "Multas");

            migrationBuilder.RenameColumn(
                name: "Duración",
                table: "Prestamos",
                newName: "Duracion");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaEntrega",
                table: "Prestamos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPrestamo",
                table: "Prestamos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "PrestamoId",
                table: "Multas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaPago",
                table: "Multas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Multas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Multas_Prestamos_PrestamoId",
                table: "Multas",
                column: "PrestamoId",
                principalTable: "Prestamos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multas_Prestamos_PrestamoId",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "FechaPrestamo",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Multas");

            migrationBuilder.RenameColumn(
                name: "Duracion",
                table: "Prestamos",
                newName: "Duración");

            migrationBuilder.AlterColumn<string>(
                name: "FechaEntrega",
                table: "Prestamos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "FechaPréstamo",
                table: "Prestamos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PrestamoId",
                table: "Multas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FechaPago",
                table: "Multas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "FechaCreación",
                table: "Multas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PréstamoId",
                table: "Multas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Multas_Prestamos_PrestamoId",
                table: "Multas",
                column: "PrestamoId",
                principalTable: "Prestamos",
                principalColumn: "Id");
        }
    }
}
