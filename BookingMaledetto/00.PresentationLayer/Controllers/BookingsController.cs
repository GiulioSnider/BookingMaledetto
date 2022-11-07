using BookingMaledetto._01.BusinessLayer.Interfaces;
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
    }
}
