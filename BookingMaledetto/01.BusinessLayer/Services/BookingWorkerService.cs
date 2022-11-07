using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.RegistrationModels;
using BookingMaledetto._03.Models.RegistrationModels.Post;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class BookingWorkerService : IBookingWorkerService
    {
        private readonly IBookingDAS _bookingDAS;
        public BookingWorkerService(IBookingDAS bookingDAS)
        {
            _bookingDAS = bookingDAS;
        }

        public ExitPostRegistrationDTO PostRegistration(PostRegistrationDTO postRegistration)
        {
            var registrationToAdd = new Registration
            {
                StartDate = postRegistration.StartDate,
                EndDate = postRegistration.EndDate,
                GuestId = postRegistration.GuestId,
                RoomId = postRegistration.RoomId
            };

            var registrationAdded = _bookingDAS.AddRegistration(registrationToAdd);

            var registrationToExit = new ExitPostRegistrationDTO
            {
                RegistrationId = registrationAdded.RegistrationId,
                StartDate = registrationAdded.StartDate,
                EndDate = registrationAdded.EndDate,
                RoomId= registrationAdded.RoomId,
                GuestId=registrationAdded.GuestId
            };

            return registrationToExit;
        }
    }
}
