using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.Interfaces;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class RoomWorkerService : IRoomWorkerService
    {
        private readonly IRoomDAS _roomDAS;
        public RoomWorkerService(IRoomDAS roomDAS)
        {
            _roomDAS = roomDAS;
        }
    }
}
