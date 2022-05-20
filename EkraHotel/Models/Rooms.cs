using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
