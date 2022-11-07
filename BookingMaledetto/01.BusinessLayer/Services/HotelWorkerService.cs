using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.Interfaces;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class HotelWorkerService : IHotelWorkerService
    {
        private readonly IHotelDAS _hotelDAS;
        public HotelWorkerService(IHotelDAS hotelDAS)
        {
            _hotelDAS = hotelDAS;
        }
    }
}
