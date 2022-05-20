using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.Incentives;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EkraHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncentivesController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public IncentivesController(ApplicationContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<IEnumerable<Incentives>> Get()
        {
            return db.Incentives.Include(x => x.Staff).ToList();
        }
        [HttpPost]
        public async Task Post(AddIncentives model)
        {
            db.Incentives.Add(new Incentives { StaffId=model.StaffId, Stars=model.Stars});
            await db.SaveChangesAsync();
        }
        [HttpPut("{staffId}")]
        public async Task Put(Guid staffId,int stars)
        {
            var staff=db.Incentives.FirstOrDefault(x => x.StaffId == staffId);
            staff.Stars += stars;
            db.Incentives.Update(staff);
            await db.SaveChangesAsync();
        }
    }
}
