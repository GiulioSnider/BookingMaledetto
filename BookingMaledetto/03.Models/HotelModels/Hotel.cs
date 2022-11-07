using BookingMaledetto._03.Models.RoomModels;

namespace BookingMaledetto._03.Models.HotelModels
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public IEnumerable<Room>? Rooms { get; set; }
    }
}
