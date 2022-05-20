using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.Reviews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EkraHotel.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public ReviewsController(ApplicationContext _db)
        {
            db = _db;
        }
        [Route("Hostel")]
        [HttpGet]
        public async Task<IEnumerable<ReviewsHotel>> Hostel()
        {
            return db.ReviewsHotels.Include(x => x.Customers).ToList();
        }
        [Route("Staff")]
        [HttpGet]
        public async Task<IEnumerable<ReviewsStaff>> Staff()
        {
            return db.ReviewsStaffs.Include(x => x.Customers).Include(x=>x.Staff).ToList();
        }
        [Route("AddHostelReviews")]
        [HttpPost]
        public async Task AddHostelfReviews(RequestReviewsHostel model)
        {
            db.ReviewsHotels.Add(new ReviewsHotel { Date=DateTime.Now , CustomersId=new Guid(User.Identity.Name), Stars=model.Stars, Text=model.Text});
            await db.SaveChangesAsync();
        }
        [Route("AddStaffReviews")]
        [HttpPost]
        public async Task AddStaffReviews(RequestReviewsStaff model)
        {
            db.ReviewsStaffs.Add(new ReviewsStaff { Date = DateTime.Now, CustomersId = new Guid(User.Identity.Name), Stars = model.Stars, Text = model.Text, StaffId=model.StaffId });
            await db.SaveChangesAsync();
        }
    }
}
