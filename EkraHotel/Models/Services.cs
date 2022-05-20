using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public ServicesType Type { get; set; }
        public int TypeId { get; set; }
        public Customers Customers { get; set; }
        public Guid CustomersId { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
    }
}
