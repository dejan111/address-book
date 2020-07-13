using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'20', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PhoneNum = table.Column<string[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactAddress",
                columns: table => new
                {
                    ContactAddressId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'20', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactAddress", x => x.ContactAddressId);
                    table.ForeignKey(
                        name: "FK_ContactAddress_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DateOfBirth", "Name", "PhoneNum" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Johnes", new[] { "0992221134", "0952211478", "0995135647" } },
                    { 2, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan Blatazar", new[] { "099578681" } },
                    { 3, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivana Ivanović", new[] { "0992221134", "0952211478", "0995135647" } },
                    { 4, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivanka Perić", new[] { "0992221134" } },
                    { 5, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iva Gordanić", new[] { "0992221134" } },
                    { 6, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivor Beleter", new[] { "0992221134", "0952211478" } },
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
                    { 3, "Svetog Petra 5", "Hvar", 3, "Hrvatska", 55223 },
                    { 4, "Svetog Ivana 2", "Hvar", 4, "Hrvatska", 55223 },
                    { 5, "Zagrebačka 2", "Hvar", 5, "Hrvatska", 55223 },
                    { 6, "Splitska 8", "Hvar", 6, "Hrvatska", 55223 },
                    { 7, "Hvarska 6", "Hvar", 7, "Hrvatska", 55223 },
                    { 8, "Svetog Petra 100", "Hvar", 8, "Hrvatska", 55223 },
                    { 9, "Kerumova 7", "Hvar", 9, "Hrvatska", 55223 },
                    { 10, "Kumrovečka 11", "Hvar", 10, "Hrvatska", 55223 },
                    { 11, "Varaždinska 1", "Hvar", 11, "Hrvatska", 55223 },
                    { 12, "Dobriše Cesarića 9", "Hvar", 12, "Hrvatska", 55223 },
                    { 13, "Krleže 4", "Hvar", 13, "Hrvatska", 55223 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactAddress_Address",
                table: "ContactAddress",
                column: "Address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactAddress_ContactId",
                table: "ContactAddress",
                column: "ContactId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Name",
                table: "Contacts",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactAddress");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
