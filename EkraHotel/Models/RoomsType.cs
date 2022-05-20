using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class RoomsType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Rooms> Rooms { get; set; }
    }
}
