using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.HotelModels;

namespace BookingMaledetto._02.DataAccessLayer.DAS
{
    public class HotelDAS : IHotelDAS
    {
        private readonly BookingMaledettoDbContext _ctx;
        public HotelDAS(BookingMaledettoDbContext ctx)
        {
            _ctx = ctx;
        }


        public Hotel Add(Hotel hotelToAdd)
        {
            var hotel = _ctx.Add(hotelToAdd);
            _ctx.SaveChanges();
            return hotel.Entity;
        }
    }
}
