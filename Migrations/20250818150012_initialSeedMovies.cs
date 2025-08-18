using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.Migrations
{
    /// <inheritdoc />
    public partial class initialSeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3397), new DateTime(2025, 8, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3420), new DateTime(2025, 8, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3440), new DateTime(2025, 8, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3449), new DateTime(2025, 8, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3429), new DateTime(2025, 8, 18, 18, 0, 11, 352, DateTimeKind.Local).AddTicks(3426) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5004), new DateTime(2025, 8, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5026), new DateTime(2025, 8, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5093), new DateTime(2025, 8, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5101), new DateTime(2025, 8, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5033), new DateTime(2025, 8, 18, 17, 58, 58, 926, DateTimeKind.Local).AddTicks(5031) });
        }
    }
}
