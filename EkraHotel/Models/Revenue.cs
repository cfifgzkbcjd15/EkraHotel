using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class Revenue
    {
        [Key]
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
    }
}
