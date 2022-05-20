namespace EkraHotel.ViewModels.Reviews
{
    public class RequestReviewsHostel
    {
        public string Text { get; set; }
        public int Stars { get; set; }
    }
    public class RequestReviewsStaff
    {
        public string Text { get; set; }
        public int Stars { get; set; }
        public Guid StaffId { get; set; }
        public Guid CustomersId { get; set; }
    }
}
