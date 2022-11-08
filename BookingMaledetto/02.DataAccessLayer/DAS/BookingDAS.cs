using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.RegistrationModels;

namespace BookingMaledetto._02.DataAccessLayer.DAS
{
    public class BookingDAS : IBookingDAS
    {
        private readonly BookingMaledettoDbContext _ctx;
        public BookingDAS(BookingMaledettoDbContext ctx)
        {
            _ctx = ctx;
        }

        public Registration AddRegistration(Registration registrationToAdd)
        {
            var registrationAdded = _ctx.Add(registrationToAdd);
            _ctx.SaveChanges();
            return registrationAdded.Entity;
        }

        public IEnumerable<Registration> GetAllRegistrations()
        {
            return _ctx.Registrations;
        }

        public void RemoveRegistration(int id)
        {
            var registrationFromDb = _ctx.Registrations.Single(registrationFromDb => 
                                        registrationFromDb.RegistrationId == id);

            _ctx.Registrations.Remove(registrationFromDb);
            _ctx.SaveChanges();
        }
    }
}
