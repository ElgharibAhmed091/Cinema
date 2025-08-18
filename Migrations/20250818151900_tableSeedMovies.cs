using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.Migrations
{
    /// <inheritdoc />
    public partial class tableSeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
