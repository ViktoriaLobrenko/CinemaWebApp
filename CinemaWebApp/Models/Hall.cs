namespace CinemaWebApp.Models
{

    public class Hall
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int SeatCount { get; set; }
        public HallType Type { get; set; }
    }
}