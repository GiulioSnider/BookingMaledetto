using BookingMaledetto._03.Models.HotelModels.Post;
using BookingMaledetto._03.Models.RoomModels.Post;

namespace BookingMaledetto._01.BusinessLayer.Interfaces
{
    public interface IRoomWorkerService
    {
        public ExitPostRoomDTO AddRoom(PostRoomDTO roomToAdd);
    }
}
