namespace manita_dotnet_assignment.Models
{
    public class OrderIndexViewModel
    {
        public required IEnumerable<Order> Orders { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
