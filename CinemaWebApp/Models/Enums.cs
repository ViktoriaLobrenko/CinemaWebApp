namespace CinemaWebApp.Models
{
    public enum HallType { Standard, VIP }
    public enum TicketStatus
    {
        Purchased,
        Reserved,
        Returned
    }
    public enum SessionStatus
    {
        Active,
        Canceled
    }
    public enum UserType { Customer, Admin }
}