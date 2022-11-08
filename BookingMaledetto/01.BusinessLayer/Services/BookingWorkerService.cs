using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.RegistrationModels;
using BookingMaledetto._03.Models.RegistrationModels.Get;
using BookingMaledetto._03.Models.RegistrationModels.Post;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class BookingWorkerService : IBookingWorkerService
    {
        private readonly IBookingDAS _bookingDAS;
        private readonly IGuestDAS _guestDAS;
        private readonly IRoomDAS _roomDAS;
        public BookingWorkerService(IBookingDAS bookingDAS, IGuestDAS guestDAS, IRoomDAS roomDAS)
        {
            _bookingDAS = bookingDAS;
            _guestDAS = guestDAS;
            _roomDAS = roomDAS;
        }


        public IEnumerable<LightRegistration> GetAllRegistrations()
        {
            var allRegistrations = _bookingDAS.GetAllRegistrations();
            var lightRegistrations = MapToLightRegistrations(allRegistrations);
            return lightRegistrations;
        }

        private IEnumerable<LightRegistration> MapToLightRegistrations(IEnumerable<Registration> allRegistrations)
        {
            var lightRegistrations = new List<LightRegistration>();

            foreach (var registration in allRegistrations)
            {
                var lightElement = new LightRegistration
                {
                    RegistrationId = registration.RegistrationId,
                    StartDate = registration.StartDate,
                    EndDate = registration.EndDate,
                    GuestId = registration.GuestId,
                    RoomId = registration.RoomId

                };

                lightRegistrations.Add(lightElement);
            }

            return lightRegistrations;
        }


        public ExitPostRegistrationDTO PostRegistration(PostRegistrationDTO postRegistration)
        {

            var guestFromId = _guestDAS.GetById(postRegistration.GuestId);
            var roomFromId = _roomDAS.GetById(postRegistration.RoomId);

            var isRoomAvailable = roomFromId.Registrations.All(registration =>
                                    postRegistration.EndDate < registration.StartDate ||
                                    postRegistration.StartDate > registration.EndDate);

            if (!isRoomAvailable)
            {
                throw new ArgumentException("Room is not available");
            }



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
                RoomId = registrationAdded.RoomId,
                GuestId = registrationAdded.GuestId
            };

            return registrationToExit;
        }
    }
}
