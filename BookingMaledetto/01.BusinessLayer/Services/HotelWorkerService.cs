using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.HotelModels;
using BookingMaledetto._03.Models.HotelModels.Post;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class HotelWorkerService : IHotelWorkerService
    {
        private readonly IHotelDAS _hotelDAS;
        public HotelWorkerService(IHotelDAS hotelDAS)
        {
            _hotelDAS = hotelDAS;
        }

        public ExitPostHotelDTO AddHotel(PostHotelDTO hotelToAdd)
        {
            var hotelWithId = MapToHotel(hotelToAdd);

            var hotelAdded = _hotelDAS.Add(hotelWithId);

            var hotelToExit = MapToExitHotel(hotelAdded);

            return hotelToExit;
        }

        private Hotel MapToHotel(PostHotelDTO hotelToAdd)
        {
            var hotelWithId = new Hotel();
            hotelWithId.Name = hotelToAdd.Name;
            hotelWithId.Description = hotelToAdd.Description;
            return hotelWithId;
        }

        private ExitPostHotelDTO MapToExitHotel(Hotel hotelToMap)
        {
            var hotelToExit = new ExitPostHotelDTO
            {
                HotelId = hotelToMap.HotelId,
                Description = hotelToMap.Description,
                Name = hotelToMap.Name
            };

            return hotelToExit;

        }
    }
}
