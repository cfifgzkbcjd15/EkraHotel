namespace EkraHotel.ViewModels.Stuff
{
    public class AddStaff
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Payments { get; set; }
        public Guid RolesId { get; set; }
    }
}
