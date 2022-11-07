using BookingMaledetto._01.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingMaledetto._00.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelWorkerService _hotelWorkerService;
        public HotelsController(IHotelWorkerService hotelWorkerService)
        {
            _hotelWorkerService = hotelWorkerService;
        }
    }
}
