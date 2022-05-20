using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class Customers
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Lives { get; set; }
    }
}
