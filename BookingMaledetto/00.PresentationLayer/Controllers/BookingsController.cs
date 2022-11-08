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
        public IActionResult PostRegistration([FromBody] PostRegistrationDTO postRegistration)
        {
            try
            {
                var registrationAdded = _bookingWorkerService.PostRegistration(postRegistration);
                return Ok(registrationAdded);

            } 
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteRegistration(int id)
        {
            try
            {
                _bookingWorkerService.DeleteRegistration(id);
                return NoContent();

            } catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
