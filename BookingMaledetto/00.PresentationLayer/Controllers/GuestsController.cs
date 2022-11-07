using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._03.Models.GuestModels.Post;
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

        [HttpPost]
        public IActionResult PostGuest([FromBody]PostGuestDTO postGuest)
        {
            return Ok();
        }
    }
}
