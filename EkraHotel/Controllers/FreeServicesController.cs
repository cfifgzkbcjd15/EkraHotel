using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.FreeServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EkraHotel.Controllers
{
    [Authorize(Roles = "admin,manager,resepshn")]
    [Route("api/[controller]")]
    [ApiController]
    public class FreeServicesController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public FreeServicesController(ApplicationContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<IEnumerable<FreeServices>> Get()
        {
            return db.FreeServices.Include(x=>x.Customers).Include(x=>x.Type).ToList();
        }
        [HttpPost]
        public async Task Post(AddFreeServices model)
        {
            db.FreeServices.Add(new FreeServices { CustomersId = model.CustomersId, TypeId = model.TypeId });
            await db.SaveChangesAsync();
        }
    }
}
