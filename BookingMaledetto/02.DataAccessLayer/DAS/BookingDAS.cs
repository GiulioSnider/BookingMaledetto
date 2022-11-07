using BookingMaledetto._02.DataAccessLayer.Interfaces;

namespace BookingMaledetto._02.DataAccessLayer.DAS
{
    public class BookingDAS : IBookingDAS
    {
        private readonly BookingMaledettoDbContext _ctx;
        public BookingDAS(BookingMaledettoDbContext ctx)
        {
            _ctx = ctx;
        }
    }
}
