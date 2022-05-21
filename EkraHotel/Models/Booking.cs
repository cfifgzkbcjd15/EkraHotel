using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EkraHotel.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public int RoomsId { get; set; }
        [ForeignKey("RoomsId")]
        public Rooms Rooms { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public Guid CustomersId { get; set; }
        [ForeignKey("CustomersId")]
        public Customers Customers { get; set; }

    }
}
