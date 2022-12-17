using HotelMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Hotel_Manager>().HasKey(hm => new
        //    {
        //        hm.HotelId,
        //        hm.ManagerId
        //    });
        //    modelBuilder.Entity<Hotel>().HasOne(h => h.Managers).WithOne().HasForeignKey<Manager>(m => m.ManagerId);

        //    modelBuilder.Entity<Manager>().HasOne(m => m.Hotel).WithOne().HasForeignKey<Hotel>(h => h.HotelId);

        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
