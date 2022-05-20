namespace EkraHotel.ViewModels.Booking
{
    public class AddBooking
    {
        public int RoomsId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public Guid CustomersId { get; set; }
    }
}
