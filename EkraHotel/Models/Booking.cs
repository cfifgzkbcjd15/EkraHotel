using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public Rooms Rooms { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public Customers Customers { get; set; }

    }
}
