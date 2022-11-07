using BookingMaledetto._03.Models.RegistrationModels.Post;

namespace BookingMaledetto._01.BusinessLayer.Interfaces
{
    public interface IBookingWorkerService
    {
        ExitPostRegistrationDTO PostRegistration(PostRegistrationDTO postRegistration);
    }
}
