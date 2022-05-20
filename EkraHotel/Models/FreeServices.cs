using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class FreeServices
    {
        [Key]
        public int Id { get; set; }
        public Customers Customers { get; set; }
        public int CustomersId { get; set; }
        public FreeType Type { get; set; }
        public int TypeId { get; set; }
    }
}
