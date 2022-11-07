using BookingMaledetto._03.Models.HotelModels;
using BookingMaledetto._03.Models.RegistrationModels;

namespace BookingMaledetto._03.Models.RoomModels
{
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public double DailyPrice { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public IEnumerable<Registration> Registrations { get; set; }
    }
}
