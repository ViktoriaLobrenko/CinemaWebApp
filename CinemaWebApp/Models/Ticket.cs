using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaWebApp.Models
{

    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public int SessionId { get; set; }

        [ForeignKey("SessionId")]
        public Session Session { get; set; }

        [Required]
        public int SeatNumber { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public TicketStatus Status { get; set; }
    }
}
