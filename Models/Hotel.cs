using System.ComponentModel.DataAnnotations;

namespace GBC_Travel_Group_48.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        [Required(ErrorMessage = "Hotel name is required.")]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(150)]
        public string Location { get; set; } = string.Empty;

        [Range(1, 10, ErrorMessage = "Star rating must be between 1 and 10.")]
        public int StarRating { get; set; }

        [Range(0.01, 10000.00, ErrorMessage = "Price per night must be greater than zero.")]
        public decimal PricePerNight { get; set; }

        [Range(0, 1000, ErrorMessage = "Rooms available must be a positive number.")]
        public int RoomsAvailable { get; set; }

        public string Amenities { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }
    }
}