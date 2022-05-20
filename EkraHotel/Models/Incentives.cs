using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class Incentives
    {
        [Key]
        public int Id { get; set; }
        public Staff Staff { get; set; }
        public Guid StaffId { get; set; }
        public int Stars { get; set; }

    }
}
