using BookingMaledetto._02.DataAccessLayer.Interfaces;

namespace BookingMaledetto._02.DataAccessLayer.DAS
{
    public class HotelDAS : IHotelDAS
    {
        private readonly BookingMaledettoDbContext _ctx;
        public HotelDAS(BookingMaledettoDbContext ctx)
        {
            _ctx = ctx;
        }
    }
}
