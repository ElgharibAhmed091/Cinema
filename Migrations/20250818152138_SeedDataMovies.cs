using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(31), new DateTime(2025, 8, 18, 18, 21, 37, 348, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(67), new DateTime(2025, 8, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(86), new DateTime(2025, 8, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(95), new DateTime(2025, 8, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(77), new DateTime(2025, 8, 18, 18, 21, 37, 349, DateTimeKind.Local).AddTicks(74) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(6989), new DateTime(2025, 8, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(7004), new DateTime(2025, 8, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(7018), new DateTime(2025, 8, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(7024), new DateTime(2025, 8, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(7011), new DateTime(2025, 8, 18, 18, 18, 58, 871, DateTimeKind.Local).AddTicks(7009) });
        }
    }
}
