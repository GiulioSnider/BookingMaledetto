namespace BookingMaledetto._03.Models.RegistrationModels.Post
{
    public class ExitPostRegistrationDTO
    {
        public int RegistrationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
    }
}
