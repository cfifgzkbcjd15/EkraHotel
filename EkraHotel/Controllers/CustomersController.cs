using EkraHotel.Data;
using EkraHotel.Models;
using EkraHotel.ViewModels.Customers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EkraHotel.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController:ControllerBase
    {
        private ApplicationContext db { get; set; }
        public CustomersController(ApplicationContext _db)
        {
            db = _db;
        }
        [HttpPost]
        public async Task Post(AddCustomers customers)
        {
            db.Customers.Add(new Customers { Email=customers.Email, FullName=customers.FullName, Lives=false, Password=customers.Password } );
            await db.SaveChangesAsync();
        }
        [HttpPut("{userId}")]
        public async Task Put(Guid userId,Customers customers)
        {
            db.Customers.Add(customers);
            await db.SaveChangesAsync();
        }
    }
}
