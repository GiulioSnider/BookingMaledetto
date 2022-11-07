using BookingMaledetto._02.DataAccessLayer.Interfaces;

namespace BookingMaledetto._02.DataAccessLayer.DAS
{
    public class GuestDAS : IGuestDAS
    {
        private readonly BookingMaledettoDbContext _ctx;
        public GuestDAS(BookingMaledettoDbContext ctx)
        {
            _ctx = ctx;
        }
    }
}
