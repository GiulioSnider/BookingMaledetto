using BookingMaledetto._03.Models.GuestModels;
using BookingMaledetto._03.Models.HotelModels;
using BookingMaledetto._03.Models.RegistrationModels;
using BookingMaledetto._03.Models.RoomModels;
using Microsoft.EntityFrameworkCore;

namespace BookingMaledetto._02.DataAccessLayer
{
    public class BookingMaledettoDbContext : DbContext
    {
        DbSet<Guest> Guests { get; set; }
        DbSet<Hotel> Hotels { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<Registration> Registrations { get; set; }

        public BookingMaledettoDbContext(DbContextOptions<BookingMaledettoDbContext> options) : base(options)
        {

        }
    }
}
