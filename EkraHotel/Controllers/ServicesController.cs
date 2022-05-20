using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EkraHotel.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public ServicesController(ApplicationContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<IEnumerable<Services>> Get()
        {
            return db.Services.Include(x=>x.Customers).Include(x=>x.Type).ToList();
        }
        [HttpPost]
        public async Task Post(AddServices model)
        {
            db.Services.Add(new Services { CustomersId= new Guid(User.Identity.Name), Date=DateTime.Now, Price=model.Price, Text=model.Text, TypeId=model.TypeId });
            await db.SaveChangesAsync();
        }
    }
}
