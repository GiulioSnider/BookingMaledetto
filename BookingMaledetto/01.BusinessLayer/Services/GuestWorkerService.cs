using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.GuestModels;
using BookingMaledetto._03.Models.GuestModels.Post;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class GuestWorkerService : IGuestWorkerService
    {
        private readonly IGuestDAS _guestDAS;
        public GuestWorkerService(IGuestDAS guestDAS)
        {
            _guestDAS = guestDAS;
        }

        public ExitPostGuestDTO AddGuest(PostGuestDTO postGuest)
        {
            var guestToAdd = new Guest
            {
                GuestId = 0,
                FirstName = postGuest.FirstName,
                LastName = postGuest.LastName
            };

            var guestAdded = _guestDAS.AddGuest(guestToAdd);

            var guestToExit = new ExitPostGuestDTO
            {
                GuestId = guestAdded.GuestId,
                FirstName = guestToAdd.FirstName,
                LastName = guestToAdd.LastName
            };

            return guestToExit;
        }
    }
}
