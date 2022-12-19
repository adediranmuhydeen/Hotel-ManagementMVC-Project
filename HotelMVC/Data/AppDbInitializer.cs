using HotelMVC.Enums;
using HotelMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HotelMVC.Data
{
    /// <summary>
    /// This is to ensure that the database is created and feed it with dummy
    /// data
    /// </summary>
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if (!context.Rooms.Any())
                {
                    context.Rooms.Add(new Room
                    {
                        Id = 1,
                        CheckInTime = DateTime.Now.ToString("f"),
                        RoomName = "LasVegas",
                        RoomNumber = 110,
                        RoomType = RoomType.SingleRoom,
                        IsAvailable = IsAvailable.Available,
                        Price = 15000.00,
                        HotelId = 1,
                        Hotel = new Hotel
                        {
                            Id = 1,
                            //HotelId = "ABC123D",
                            HotelName = "Paradise",
                            Address = "grater Manchester",
                            City = "manchester",
                            EmailAddress = "hotel@excample.com",
                            PhoneNumber = "08098765432",
                            State = "United Kingdom",
                            Rating = HotelRating.FiveStar,
                            ManagerId = 1
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Managers.Any())
                {
                    var res = new Manager
                    {
                        Id = 1,
                        ManagerUserName = "FirstManager",
                        FirstName = "John",
                        LastName = "enjamine",
                        Email = "manager@example.com",
                        Password = "manager",
                        PhoneNumber = "08061695555",
                        Title = Title.Mr,
                        HotelId = 1
                    };
                    //context.Managers.Add(new Manager
                    //{
                    //    Id = 1,
                    //    ManagerUserName = "FirstManager",
                    //    FirstName = "John",
                    //    LastName = "enjamine",
                    //    Email = "manager@example.com",
                    //    Password = "manager",
                    //    PhoneNumber = "08061695555",
                    //    Title = Title.Mr,
                    //    Hotel = new Hotel { Id = 1}
                    //});
                    var resss = res;
                    var sfs = context.SaveChanges();
                }
                //Rooms


                //Customers
                if (!context.Customers.Any())
                {
                    context.Customers.Add(new Customer
                    {

                        FirstName = "Waris",
                        LastName = "Salami",
                        Email = "customer@example.com",
                        Password = "customer",
                        PhoneNumber = "08089765432",
                        Title = Title.Dr,
                        Id = 1,
                        RoomId = 1,
                        HotelId = 1
                    });
                    context.SaveChanges();
                }
                //Admins
                if (!context.Admins.Any())
                {
                    context.Admins.Add(new Admin
                    {
                        FirstName = "Olayinka",
                        MiddleName = "David",
                        LastName = "Sulaiman",
                        Email = "admin@example.com",
                        Password = "admin",
                        PhoneNumber = "08089765432",
                        Title = Title.Dr,
                        AdminName = "firstAdmin",
                        HotelId = 1
                    });
                    context.SaveChanges();
                }
                if (!context.Hotels.Any())
                {
                    context.Hotels.Add(new Hotel
                    {
                        Id = 1,
                        //HotelId = "ABC123D",
                        HotelName = "Paradise",
                        Address = "grater Manchester",
                        City = "manchester",
                        EmailAddress = "hotel@excample.com",
                        PhoneNumber = "08098765432",
                        State = "United Kingdom",
                        Rating = HotelRating.FiveStar,
                        ManagerId = 1
                        //HotelManager = new Manager { Id = 1 }
                    });
                    context.SaveChanges();
                }

            }




        }
    }
}

