using BookingMaledetto._01.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingMaledetto._00.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomWorkerService _roomWorkerService;
        public RoomsController(IRoomWorkerService roomWorkerService)
        {
            _roomWorkerService = roomWorkerService;
        }
    }
}
