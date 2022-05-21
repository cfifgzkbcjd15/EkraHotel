using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EkraHotel.Models
{
    public class Rooms
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public RoomsType Type { get; set; }
        public int TypeId { get; set;}
        public bool Disabled { get; set; }
        [JsonIgnore]
        public Booking Bookings { get; set; }
        public int BookingsId { get; set; }
    }
}
