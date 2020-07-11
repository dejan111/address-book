using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DateOfBirth", "Name", "PhoneNum" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Johnes", new[] { "0992221134" } },
                    { 2, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan Blatazar", new[] { "0992221134" } },
                    { 3, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivana Ivanović", new[] { "0992221134" } },
                    { 4, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivanka Perić", new[] { "0992221134" } },
                    { 5, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iva Gordanić", new[] { "0992221134" } },
                    { 6, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivor Beleter", new[] { "0992221134" } },
                    { 7, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petar Kajić", new[] { "0992221134" } },
                    { 8, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingrid Budić", new[] { "0992221134" } },
                    { 9, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Igor Igorić", new[] { "0992221134" } },
                    { 10, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valentino Valentić", new[] { "0992221134" } },
                    { 11, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbara Ivković", new[] { "0992221134" } },
                    { 12, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tea Teić", new[] { "0992221134" } },
                    { 13, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viktor Draganić", new[] { "0992221134" } }
                });

            migrationBuilder.InsertData(
                table: "ContactAddress",
                columns: new[] { "ContactAddressId", "Address", "City", "ContactId", "Country", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Svetog Petra 2", "Hvar", 1, "Hrvatska", 55223 },
                    { 2, "Zlarinska 6", "Šibenik", 2, "Hrvatska", 40235 },
                    { 3, "Svetog Petra 2", "Hvar", 3, "Hrvatska", 55223 },
                    { 4, "Svetog Petra 2", "Hvar", 4, "Hrvatska", 55223 },
                    { 5, "Svetog Petra 2", "Hvar", 5, "Hrvatska", 55223 },
                    { 6, "Svetog Petra 2", "Hvar", 6, "Hrvatska", 55223 },
                    { 7, "Svetog Petra 2", "Hvar", 7, "Hrvatska", 55223 },
                    { 8, "Svetog Petra 2", "Hvar", 8, "Hrvatska", 55223 },
                    { 9, "Svetog Petra 2", "Hvar", 9, "Hrvatska", 55223 },
                    { 10, "Svetog Petra 2", "Hvar", 10, "Hrvatska", 55223 },
                    { 11, "Svetog Petra 2", "Hvar", 11, "Hrvatska", 55223 },
                    { 12, "Svetog Petra 2", "Hvar", 12, "Hrvatska", 55223 },
                    { 13, "Svetog Petra 2", "Hvar", 13, "Hrvatska", 55223 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ContactAddress",
                keyColumn: "ContactAddressId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
