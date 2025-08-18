using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5622), new DateTime(2025, 8, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5641), new DateTime(2025, 8, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5655), new DateTime(2025, 8, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5662), new DateTime(2025, 8, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5648), new DateTime(2025, 8, 18, 18, 22, 43, 243, DateTimeKind.Local).AddTicks(5646) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
