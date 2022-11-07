using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.Interfaces;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class BookingWorkerService : IBookingWorkerService
    {
        private readonly IBookingDAS _bookingDAS;
        public BookingWorkerService(IBookingDAS bookingDAS)
        {
            _bookingDAS = bookingDAS;
        }
    }
}
