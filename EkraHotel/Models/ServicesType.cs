using System.ComponentModel.DataAnnotations;

namespace EkraHotel.Models
{
    public class ServicesType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FreeServices> FreeServices { get; set; }
    }
}
