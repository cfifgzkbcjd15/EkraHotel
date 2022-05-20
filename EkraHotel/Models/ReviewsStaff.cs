using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class ReviewsStaff
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int Stars { get; set; }
        public Staff Staff { get; set; }
        public Guid StaffId { get; set; }
        public Customers Customers { get; set; }
        public Guid CustomersId { get; set; }
        public DateTime Date { get; set; }
    }
}
