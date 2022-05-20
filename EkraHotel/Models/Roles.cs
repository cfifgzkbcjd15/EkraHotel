using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EkraHotel.Models
{
    public class Roles
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        
    }
}
