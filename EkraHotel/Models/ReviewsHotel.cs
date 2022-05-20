using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class ReviewsHotel
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public Customers Customers { get; set; }
        public Guid CustomersId { get; set; }
        public int Stars {get; set; }
        public DateTime Date { get; set; }
    }
}
