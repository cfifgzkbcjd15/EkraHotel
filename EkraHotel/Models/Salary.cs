using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        public Staff Staff { get; set; }
        public Guid StaffId { get; set; }
        public int Payments { get; set; }
        public int Bonuses { get; set; }
        public DateTime Date { get; set; }

    }
}
