using BookingMaledetto._03.Models.HotelModels.Post;
using BookingMaledetto._03.Models.HotelModels;

namespace BookingMaledetto._01.BusinessLayer.Interfaces
{
    public interface IHotelWorkerService
    {
        public ExitPostHotelDTO AddHotel(PostHotelDTO hotelToAdd);
    }
}
