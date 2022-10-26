using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phoenix_Store.Persistence.Migrations
{
    public partial class addviewcounttoproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productFeatures_Products_ProductId",
                table: "productFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productFeatures",
                table: "productFeatures");

            migrationBuilder.RenameTable(
                name: "productFeatures",
                newName: "ProductFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_productFeatures_ProductId",
                table: "ProductFeatures",
                newName: "IX_ProductFeatures_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFeatures",
                table: "ProductFeatures",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 13, 17, 40, 42, 146, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 13, 17, 40, 42, 146, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 13, 17, 40, 42, 146, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatures_Products_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatures_Products_ProductId",
                table: "ProductFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFeatures",
                table: "ProductFeatures");

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "ProductFeatures",
                newName: "productFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "productFeatures",
                newName: "IX_productFeatures_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productFeatures",
                table: "productFeatures",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 3, 14, 5, 3, 55, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 3, 14, 5, 3, 55, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 6, 3, 14, 5, 3, 55, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.AddForeignKey(
                name: "FK_productFeatures_Products_ProductId",
                table: "productFeatures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
