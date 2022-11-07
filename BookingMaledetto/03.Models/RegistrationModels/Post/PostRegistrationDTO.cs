namespace BookingMaledetto._03.Models.RegistrationModels.Post
{
    public class PostRegistrationDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
    }
}
