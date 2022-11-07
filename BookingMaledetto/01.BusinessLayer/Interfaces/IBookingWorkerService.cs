using BookingMaledetto._03.Models.RegistrationModels.Get;
using BookingMaledetto._03.Models.RegistrationModels.Post;

namespace BookingMaledetto._01.BusinessLayer.Interfaces
{
    public interface IBookingWorkerService
    {
        IEnumerable<LightRegistration> GetAllRegistrations();
        ExitPostRegistrationDTO PostRegistration(PostRegistrationDTO postRegistration);
    }
}
