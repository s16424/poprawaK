using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kolokwium3.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    IdArtist = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.IdArtist);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    IdEvent = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.IdEvent);
                });

            migrationBuilder.CreateTable(
                name: "Organisers",
                columns: table => new
                {
                    IdOrganiser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisers", x => x.IdOrganiser);
                });

            migrationBuilder.CreateTable(
                name: "ArtistEvents",
                columns: table => new
                {
                    IdEvent = table.Column<int>(nullable: false),
                    IdArtist = table.Column<int>(nullable: false),
                    EventIdEvent = table.Column<int>(nullable: true),
                    ArtistIdArtist = table.Column<int>(nullable: true),
                    PerformanceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistEvents", x => new { x.IdArtist, x.IdEvent });
                    table.ForeignKey(
                        name: "FK_ArtistEvents_Artists_ArtistIdArtist",
                        column: x => x.ArtistIdArtist,
                        principalTable: "Artists",
                        principalColumn: "IdArtist",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArtistEvents_Events_EventIdEvent",
                        column: x => x.EventIdEvent,
                        principalTable: "Events",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventOrganisers",
                columns: table => new
                {
                    IdOrganiser = table.Column<int>(nullable: false),
                    IdEvent = table.Column<int>(nullable: false),
                    OrganiserIdOrganiser = table.Column<int>(nullable: true),
                    EventIdEvent = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOrganisers", x => new { x.IdEvent, x.IdOrganiser });
                    table.ForeignKey(
                        name: "FK_EventOrganisers_Events_EventIdEvent",
                        column: x => x.EventIdEvent,
                        principalTable: "Events",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventOrganisers_Organisers_OrganiserIdOrganiser",
                        column: x => x.OrganiserIdOrganiser,
                        principalTable: "Organisers",
                        principalColumn: "IdOrganiser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistEvents_ArtistIdArtist",
                table: "ArtistEvents",
                column: "ArtistIdArtist");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistEvents_EventIdEvent",
                table: "ArtistEvents",
                column: "EventIdEvent");

            migrationBuilder.CreateIndex(
                name: "IX_EventOrganisers_EventIdEvent",
                table: "EventOrganisers",
                column: "EventIdEvent");

            migrationBuilder.CreateIndex(
                name: "IX_EventOrganisers_OrganiserIdOrganiser",
                table: "EventOrganisers",
                column: "OrganiserIdOrganiser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistEvents");

            migrationBuilder.DropTable(
                name: "EventOrganisers");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Organisers");
        }
    }
}
