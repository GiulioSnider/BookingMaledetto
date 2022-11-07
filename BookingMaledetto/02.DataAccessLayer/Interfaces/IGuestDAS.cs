using BookingMaledetto._03.Models.GuestModels;

namespace BookingMaledetto._02.DataAccessLayer.Interfaces
{
    public interface IGuestDAS
    {
        Guest AddGuest(Guest guestToAdd);
    }
}
