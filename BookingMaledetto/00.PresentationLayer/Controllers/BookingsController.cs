using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._03.Models.RegistrationModels.Post;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingMaledetto._00.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingWorkerService _bookingWorkerService;
        public BookingsController(IBookingWorkerService bookingWorkerService)
        {
            _bookingWorkerService = bookingWorkerService;
        }

        [HttpGet]
        public IActionResult GetAllBookings()
        {
            var registrations = _bookingWorkerService.GetAllRegistrations();
            return Ok(registrations);
        }

        [HttpPost]
        public IActionResult PostRegistration([FromBody]PostRegistrationDTO postRegistration)
        {
            var registrationAdded = _bookingWorkerService.PostRegistration(postRegistration);
            return Ok(registrationAdded);
        }
    }
}
