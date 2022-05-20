using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.Booking;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EkraHotel.Controllers
{
    [Authorize(Roles = "admin,manager,resepshn")]
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public BookingController(ApplicationContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<IEnumerable<Booking>> Get()
        {
            return db.Bookings.Include(x=>x.Customers).Include(x=>x.Rooms).ToList();
        }
        [HttpGet]
        public async Task Post(AddBooking model)
        {
            db.Bookings.Add(new Booking { CustomersId=model.CustomersId, RoomsId=model.RoomsId, DateStart=model.DateStart, DateEnd=model.DateEnd });
            await db.SaveChangesAsync();
        }

    }
}
