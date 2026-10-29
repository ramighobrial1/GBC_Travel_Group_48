using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GBC_Travel_Group_48.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2026, 11, 15, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 15, 8, 0, 0, 0, DateTimeKind.Utc), 350.00m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime", "Destination", "FlightNumber", "Price", "SeatsAvailable" },
                values: new object[] { new DateTime(2026, 11, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 16, 10, 30, 0, 0, DateTimeKind.Utc), "Calgary (YYC)", "WS456", 290.00m, 30 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "Amenities", "Name", "PricePerNight", "RoomsAvailable", "StarRating" },
                values: new object[] { "", "Grand Toronto Hotel", 250.00m, 0, 9 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "Amenities", "Location", "Name", "PricePerNight", "RoomsAvailable", "StarRating" },
                values: new object[] { "", "Markham, ON", "Markham Suites", 180.00m, 0, 8 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "Amenities", "Location", "Name", "RoomsAvailable", "StarRating" },
                values: new object[] { "", "Niagara Falls, ON", "Niagara Fallsview Lodge", 0, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2026, 11, 2, 10, 40, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 2, 8, 15, 0, 0, DateTimeKind.Utc), 349.00m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime", "Destination", "FlightNumber", "Price", "SeatsAvailable" },
                values: new object[] { new DateTime(2026, 11, 2, 13, 52, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 2, 11, 30, 0, 0, DateTimeKind.Utc), "Vancouver (YVR)", "WS705", 372.00m, 12 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Airline", "ArrivalTime", "DepartureTime", "Destination", "FlightNumber", "Origin", "Price", "SeatsAvailable" },
                values: new object[,]
                {
                    { 3, "Porter", new DateTime(2026, 11, 2, 18, 20, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 2, 14, 5, 0, 0, DateTimeKind.Utc), "Vancouver (YVR)", "PD511", "Toronto (YYZ)", 398.00m, 8 },
                    { 4, "Air Canada", new DateTime(2026, 11, 2, 22, 10, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 2, 19, 45, 0, 0, DateTimeKind.Utc), "Vancouver (YVR)", "AC131", "Toronto (YYZ)", 415.00m, 20 },
                    { 5, "WestJet", new DateTime(2026, 11, 3, 11, 30, 0, 0, DateTimeKind.Utc), new DateTime(2026, 11, 3, 9, 0, 0, 0, DateTimeKind.Utc), "Calgary (YYC)", "WS202", "Toronto (YYZ)", 280.00m, 30 }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1,
                columns: new[] { "Amenities", "Name", "PricePerNight", "RoomsAvailable", "StarRating" },
                values: new object[] { "Free Wi-Fi, Pool, Parking, Breakfast, Gym", "Harbourfront Inn", 189.00m, 12, 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2,
                columns: new[] { "Amenities", "Location", "Name", "PricePerNight", "RoomsAvailable", "StarRating" },
                values: new object[] { "Free Wi-Fi, Restaurant, Bar", "Montreal, QC", "Old Port Suites", 159.00m, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3,
                columns: new[] { "Amenities", "Location", "Name", "RoomsAvailable", "StarRating" },
                values: new object[] { "Ocean View, Spa, Free Wi-Fi, Gym", "Vancouver, BC", "Pacific Rim Resort", 8, 5 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Amenities", "ImageUrl", "Location", "Name", "PricePerNight", "RoomsAvailable", "StarRating" },
                values: new object[,]
                {
                    { 4, "Free Parking, Pet Friendly, Fireplace", null, "Banff, AB", "Rocky Mountain Lodge", 140.00m, 15, 3 },
                    { 5, "Free Wi-Fi, Breakfast, Fitness Center", null, "Ottawa, ON", "Capital View Hotel", 175.00m, 10, 4 }
                });
        }
    }
}
