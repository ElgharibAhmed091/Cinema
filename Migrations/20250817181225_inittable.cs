using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.Migrations
{
    /// <inheritdoc />
    public partial class inittable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 17, 21, 12, 23, 917, DateTimeKind.Local).AddTicks(3574), new DateTime(2025, 8, 17, 21, 12, 23, 917, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 17, 21, 12, 23, 917, DateTimeKind.Local).AddTicks(3590), new DateTime(2025, 8, 17, 21, 12, 23, 917, DateTimeKind.Local).AddTicks(3588) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "CartItems");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 17, 20, 1, 19, 818, DateTimeKind.Local).AddTicks(9791), new DateTime(2025, 8, 17, 20, 1, 19, 818, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 17, 20, 1, 19, 818, DateTimeKind.Local).AddTicks(9812), new DateTime(2025, 8, 17, 20, 1, 19, 818, DateTimeKind.Local).AddTicks(9808) });
        }
    }
}
