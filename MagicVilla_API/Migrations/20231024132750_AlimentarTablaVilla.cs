using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Linda Villa a Las Afueras De Medellin", new DateTime(2023, 10, 24, 8, 27, 49, 832, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 10, 24, 8, 27, 49, 832, DateTimeKind.Local).AddTicks(3306), "", 300, "VillaDuran", 15, 3000000.0 },
                    { 2, "", "Linda Villa a Las Afueras De Pereira", new DateTime(2023, 10, 24, 8, 27, 49, 832, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 10, 24, 8, 27, 49, 832, DateTimeKind.Local).AddTicks(3328), "", 200, "VillaDuran2", 15, 2000000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
