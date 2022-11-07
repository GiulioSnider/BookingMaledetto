using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._01.BusinessLayer.Services;
using BookingMaledetto._03.Models.HotelModels.Post;
using BookingMaledetto._03.Models.RoomModels.Post;
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

        [HttpPost]
        public IActionResult PostRoom([FromBody] PostRoomDTO postRoomDTO)
        {
            var roomAdded = _roomWorkerService.AddRoom(postRoomDTO);
            return Ok(roomAdded);
        }
    }
}
