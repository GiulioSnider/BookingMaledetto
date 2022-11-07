using BookingMaledetto._01.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingMaledetto._00.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly IGuestWorkerService _guestWorkerService;
        public GuestsController(IGuestWorkerService guestWorkerService)
        {
            _guestWorkerService = guestWorkerService;
        }
    }
}
