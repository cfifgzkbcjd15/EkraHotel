using EkraHotel.Data;
using EkraHotel.Models;
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
    }
}
