using GBC_Travel_Group_48.Models;
using Microsoft.EntityFrameworkCore;

namespace GBC_Travel_Group_48.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Hotels
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { HotelId = 1, Name = "Grand Toronto Hotel", Location = "Toronto, ON", StarRating = 9, PricePerNight = 250.00m },
                new Hotel { HotelId = 2, Name = "Markham Suites", Location = "Markham, ON", StarRating = 8, PricePerNight = 180.00m },
                new Hotel { HotelId = 3, Name = "Niagara Fallsview Lodge", Location = "Niagara Falls, ON", StarRating = 10, PricePerNight = 320.00m }
            );

            // Seed Flights (using UTC for PostgreSQL compatibility)
            modelBuilder.Entity<Flight>().HasData(
                new Flight 
                { 
                    FlightId = 1, 
                    Airline = "Air Canada", 
                    FlightNumber = "AC123", 
                    Origin = "Toronto (YYZ)", 
                    Destination = "Vancouver (YVR)", 
                    DepartureTime = new DateTime(2026, 11, 15, 8, 0, 0, DateTimeKind.Utc), 
                    ArrivalTime = new DateTime(2026, 11, 15, 11, 0, 0, DateTimeKind.Utc), 
                    Price = 350.00m, 
                    SeatsAvailable = 45 
                },
                new Flight 
                { 
                    FlightId = 2, 
                    Airline = "WestJet", 
                    FlightNumber = "WS456", 
                    Origin = "Toronto (YYZ)", 
                    Destination = "Calgary (YYC)", 
                    DepartureTime = new DateTime(2026, 11, 16, 10, 30, 0, DateTimeKind.Utc), 
                    ArrivalTime = new DateTime(2026, 11, 16, 13, 0, 0, DateTimeKind.Utc), 
                    Price = 290.00m, 
                    SeatsAvailable = 30 
                }
            );
        }
    }
}