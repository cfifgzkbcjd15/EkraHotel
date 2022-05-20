using EkraHotel.Models;
using Microsoft.EntityFrameworkCore;

namespace EkraHotel.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ServicesType> ServicesTypes { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ReviewsHotel> ReviewsHotels { get; set; }
        public DbSet<ReviewsStaff> ReviewsStaffs { get; set; }
        public DbSet<Revenue> Revenue { get; set; }
        public DbSet<Incentives> Incentives { get; set; }
        public DbSet<FreeType> FreeTypes { get; set; }
        public DbSet<FreeServices> FreeServices { get; set; }
        public DbSet<Salary> Salary { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
    }
}
