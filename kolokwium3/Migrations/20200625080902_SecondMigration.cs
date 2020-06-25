using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kolokwium3.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArtistEvents",
                columns: new[] { "IdArtist", "IdEvent", "ArtistIdArtist", "EventIdEvent", "PerformanceDate" },
                values: new object[,]
                {
                    { 1, 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "IdArtist", "Nickname" },
                values: new object[,]
                {
                    { 1, "Ania" },
                    { 2, "Przemek" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "IdEvent", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koncert", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SZtuka teatralna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistEvents",
                keyColumns: new[] { "IdArtist", "IdEvent" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ArtistEvents",
                keyColumns: new[] { "IdArtist", "IdEvent" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "IdArtist",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "IdArtist",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "IdEvent",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "IdEvent",
                keyValue: 2);
        }
    }
}
