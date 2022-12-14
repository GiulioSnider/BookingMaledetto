using BookingMaledetto._03.Models.RegistrationModels;

namespace BookingMaledetto._02.DataAccessLayer.Interfaces
{
    public interface IBookingDAS
    {
        Registration AddRegistration(Registration registrationToAdd);
        IEnumerable<Registration> GetAllRegistrations();
        void RemoveRegistration(int id);
    }
}
