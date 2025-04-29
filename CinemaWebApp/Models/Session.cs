namespace CinemaWebApp.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public DateTime StartTime { get; set; }
        public decimal TicketPrice { get; set; }
        public SessionStatus Status { get; set; }

        public Movie Movie { get; set; } = null!;
        public Hall Hall { get; set; } = null!;
    }
}