using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.Interfaces;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class GuestWorkerService : IGuestWorkerService
    {
        private readonly IGuestDAS _guestDAS;
        public GuestWorkerService(IGuestDAS guestDAS)
        {
            _guestDAS = guestDAS;
        }
    }
}
