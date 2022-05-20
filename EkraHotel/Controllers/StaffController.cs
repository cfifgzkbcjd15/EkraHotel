using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.Stuff;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EkraHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public StaffController(ApplicationContext _db)
        {
            db = _db;
        }
        [HttpPost]
        public async Task AddStaff(AddStaff model)
        {
            db.Staffs.Add(new Staff { Email=model.Email,Password=model.Password, FullName=model.FullName, RolesId=model.RolesId, Payments=model.Payments, Id=Guid.NewGuid() });
            await db.SaveChangesAsync();
        }
        [HttpPut("{userId}")]
        public async Task EditStaff(Guid userId,AddStaff model)
        {
            db.Staffs.Update(new Staff { Email = model.Email, Password = model.Password, FullName = model.FullName, RolesId = model.RolesId, Payments = model.Payments, Id = Guid.NewGuid() });
            await db.SaveChangesAsync();
        }
    }
}
