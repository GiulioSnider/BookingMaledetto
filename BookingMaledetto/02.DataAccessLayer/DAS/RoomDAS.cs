using BookingMaledetto._02.DataAccessLayer.Interfaces;

namespace BookingMaledetto._02.DataAccessLayer.DAS
{
    public class RoomDAS : IRoomDAS
    {
        private readonly BookingMaledettoDbContext _ctx;
        public RoomDAS(BookingMaledettoDbContext ctx)
        {
            _ctx = ctx;
        }
    }
}
