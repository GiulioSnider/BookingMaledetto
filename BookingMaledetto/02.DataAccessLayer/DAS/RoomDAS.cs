using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.HotelModels;
using BookingMaledetto._03.Models.RoomModels;
using Microsoft.EntityFrameworkCore;

namespace BookingMaledetto._02.DataAccessLayer.DAS
{
    public class RoomDAS : IRoomDAS
    {
        private readonly BookingMaledettoDbContext _ctx;
        public RoomDAS(BookingMaledettoDbContext ctx)
        {
            _ctx = ctx;
        }

        public Room Add(Room roomToAdd)
        {
            var room = _ctx.Add(roomToAdd);
            _ctx.SaveChanges();
            return room.Entity;
        }

        public Room GetById(int roomId)
        {
            return _ctx.Rooms.Include(room => room.Registrations).Single(room => room.RoomId == roomId);
        }
    }
}
