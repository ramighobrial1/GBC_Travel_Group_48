using System.ComponentModel.DataAnnotations;

namespace GBC_Travel_Group_48.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        
        [Required(ErrorMessage = "Airline name is required.")]
        [StringLength(100)]
        public string Airline { get; set; } = string.Empty;

        [Required(ErrorMessage = "Flight number is required.")]
        [StringLength(10)]
        public string FlightNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Origin is required.")]
        [StringLength(100)]
        public string Origin { get; set; } = string.Empty;

        [Required(ErrorMessage = "Destination is required.")]
        [StringLength(100)]
        public string Destination { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTime DepartureTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ArrivalTime { get; set; }

        [Range(0.01, 10000.00, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        [Range(0, 1000, ErrorMessage = "Seats available must be a positive number.")]
        public int SeatsAvailable { get; set; }
    }
}