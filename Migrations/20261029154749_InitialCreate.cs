using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GBC_Travel_Group_48.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Airline = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    FlightNumber = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Origin = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Destination = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    SeatsAvailable = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Location = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    StarRating = table.Column<int>(type: "integer", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "numeric", nullable: false),
                    RoomsAvailable = table.Column<int>(type: "integer", nullable: false),
                    Amenities = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Airline", "ArrivalTime", "DepartureTime", "Destination", "FlightNumber", "Origin", "Price", "SeatsAvailable" },
                values: new object[,]
                {
                    { 1, "Air Canada", new DateTime(2026, 11, 2, 10, 40, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 2, 8, 15, 0, 0, DateTimeKind.Utc), "Vancouver (YVR)", "AC123", "Toronto (YYZ)", 349.00m, 45 },
                    { 2, "WestJet", new DateTime(2026, 11, 2, 13, 52, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 2, 11, 30, 0, 0, DateTimeKind.Utc), "Vancouver (YVR)", "WS705", "Toronto (YYZ)", 372.00m, 12 },
                    { 3, "Porter", new DateTime(2026, 11, 2, 18, 20, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 2, 14, 5, 0, 0, DateTimeKind.Utc), "Vancouver (YVR)", "PD511", "Toronto (YYZ)", 398.00m, 8 },
                    { 4, "Air Canada", new DateTime(2026, 11, 2, 22, 10, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 2, 19, 45, 0, 0, DateTimeKind.Utc), "Vancouver (YVR)", "AC131", "Toronto (YYZ)", 415.00m, 20 },
                    { 5, "WestJet", new DateTime(2026, 11, 3, 11, 30, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 3, 9, 0, 0, 0, DateTimeKind.Utc), "Calgary (YYC)", "WS202", "Toronto (YYZ)", 280.00m, 30 }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Amenities", "ImageUrl", "Location", "Name", "PricePerNight", "RoomsAvailable", "StarRating" },
                values: new object[,]
                {
                    { 1, "Free Wi-Fi, Pool, Parking, Breakfast, Gym", null, "Toronto, ON", "Harbourfront Inn", 189.00m, 12, 4 },
                    { 2, "Free Wi-Fi, Restaurant, Bar", null, "Montreal, QC", "Old Port Suites", 159.00m, 5, 4 },
                    { 3, "Ocean View, Spa, Free Wi-Fi, Gym", null, "Vancouver, BC", "Pacific Rim Resort", 320.00m, 8, 5 },
                    { 4, "Free Parking, Pet Friendly, Fireplace", null, "Banff, AB", "Rocky Mountain Lodge", 140.00m, 15, 3 },
                    { 5, "Free Wi-Fi, Breakfast, Fitness Center", null, "Ottawa, ON", "Capital View Hotel", 175.00m, 10, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
