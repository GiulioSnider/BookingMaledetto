using BookingMaledetto._03.Models.GuestModels.Post;

namespace BookingMaledetto._01.BusinessLayer.Interfaces
{
    public interface IGuestWorkerService
    {
        ExitPostGuestDTO AddGuest(PostGuestDTO postGuest);
    }
}
