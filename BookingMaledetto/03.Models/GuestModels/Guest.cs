using BookingMaledetto._03.Models.RegistrationModels;

namespace BookingMaledetto._03.Models.GuestModels
{
    public class Guest
    {
        public int GuestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Registration>? Registrations { get; set; }
    }
}
