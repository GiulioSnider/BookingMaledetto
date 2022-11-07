using BookingMaledetto._03.Models.GuestModels;
using BookingMaledetto._03.Models.RoomModels;

namespace BookingMaledetto._03.Models.RegistrationModels
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GuestId { get; set; }
        public Guest Guest { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
