namespace CinemaWebApp.Models
{

    public class Discount
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public double Percentage { get; set; }
        public bool IsForLoyalCustomers { get; set; }
    }
}