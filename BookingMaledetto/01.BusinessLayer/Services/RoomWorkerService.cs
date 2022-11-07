using BookingMaledetto._01.BusinessLayer.Interfaces;
using BookingMaledetto._02.DataAccessLayer.DAS;
using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.HotelModels.Post;
using BookingMaledetto._03.Models.HotelModels;
using BookingMaledetto._03.Models.RoomModels.Post;
using BookingMaledetto._03.Models.RoomModels;

namespace BookingMaledetto._01.BusinessLayer.Services
{
    public class RoomWorkerService : IRoomWorkerService
    {
        private readonly IRoomDAS _roomDAS;
        public RoomWorkerService(IRoomDAS roomDAS)
        {
            _roomDAS = roomDAS;
        }

        public ExitPostRoomDTO AddRoom(PostRoomDTO roomToAdd)
        {
            var roomWithId = MapToRoom(roomToAdd);

            var roomAdded = _roomDAS.Add(roomWithId);

            var roomToExit = MapToExitRoom(roomAdded);

            return roomToExit;
        }

        private Room MapToRoom(PostRoomDTO roomToAdd)
        {
            var roomWithId = new Room();
            roomWithId.RoomNumber = roomToAdd.RoomNumber;
            roomWithId.DailyPrice = roomToAdd.DailyPrice;
            roomWithId.HotelId = roomToAdd.HotelId;
            return roomWithId;
        }

        private ExitPostRoomDTO MapToExitRoom(Room roomToMap)
        {
            var roomToExit = new ExitPostRoomDTO
            {
                RoomId = roomToMap.RoomId,
                RoomNumber = roomToMap.RoomNumber,
                DailyPrice = roomToMap.DailyPrice,
                HotelId = roomToMap.HotelId
            };

            return roomToExit;

        }
    }
}
