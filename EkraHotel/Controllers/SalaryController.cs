using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.Salary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EkraHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private ApplicationContext db { get; set; }
        public SalaryController(ApplicationContext _db)
        {
            db = _db;
        }

        [Route("Revenue")]
        [HttpGet]
        public async Task<IEnumerable<Revenue>> Revenue()
        {
            return db.Revenue.ToList();
        }

        [HttpGet]
        public async Task<IEnumerable<Salary>> Get()
        {
            return db.Salary.Include(x=>x.Staff).ToList();
        }
        [HttpPost]
        public async Task Post(AddSalary model)
        {
            db.Salary.Add(new Salary { Bonuses=model.Bonuses, Date=DateTime.Now, Payments=model.Payments, StaffId=model.StaffId});
            await db.SaveChangesAsync();
        }
    }
}
