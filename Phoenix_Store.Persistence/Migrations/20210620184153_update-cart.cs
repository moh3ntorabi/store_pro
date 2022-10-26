using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phoenix_Store.Persistence.Migrations
{
    public partial class updatecart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 20, 23, 11, 52, 406, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 20, 23, 11, 52, 406, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 20, 23, 11, 52, 406, DateTimeKind.Local).AddTicks(3056));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 20, 0, 50, 53, 911, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 20, 0, 50, 53, 911, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 20, 0, 50, 53, 911, DateTimeKind.Local).AddTicks(5837));
        }
    }
}
