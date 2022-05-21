using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.Booking;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EkraHotel.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public BookingController(ApplicationContext _db)
        {
            db = _db;
        }
        //[Authorize(Roles = "admin,manager,resepshn")]
        [HttpGet]
        public async Task<IEnumerable<Booking>> Get()
        {
            var rooms = db.Rooms.Include(x => x.Bookings).ThenInclude(x=>x.Customers).ToList();
            foreach(var i in rooms.Where(x => x.Bookings.DateEnd < DateTime.Now&&!x.Disabled))
            {
                i.Bookings.Customers.Lives = false;
                db.Bookings.Update(i.Bookings);
                i.Disabled = true;
                db.Rooms.Update(i);
            }
            await db.SaveChangesAsync();
            return db.Bookings.Include(x=>x.Customers).Include(x=>x.Rooms).ToList();
        }
        [HttpPost]
        public async Task Post(AddBooking model)
        {
            var rooms = db.Rooms.FirstOrDefault(x => x.Id == model.RoomsId);
            if (rooms != null) {
            rooms.Disabled = true;
            db.Rooms.Update(rooms);
            db.Bookings.Add(new Booking { CustomersId= new Guid(User.Identity.Name), RoomsId=model.RoomsId, DateStart=model.DateStart, DateEnd=model.DateEnd });
            await db.SaveChangesAsync();
            }
        }

    }
}
