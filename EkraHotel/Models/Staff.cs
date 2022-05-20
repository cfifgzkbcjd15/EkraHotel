using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EkraHotel.Models
{
    public class Staff
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Payments { get; set; }
        public Guid RolesId { get; set; }
        [JsonIgnore]
        [ForeignKey("RolesId")]
        public Roles Roles { get; set; }
        

    }
}
