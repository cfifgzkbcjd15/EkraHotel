using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EkraHotel.Models
{
    public class FreeServices
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("CustomersId")]
        public Customers Customers { get; set; }
        public Guid CustomersId { get; set; }

        [ForeignKey("TypeId")]
        public FreeType Type { get; set; }
        public int TypeId { get; set; }
    }
}
