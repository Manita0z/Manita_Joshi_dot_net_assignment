
using manita_dotnet_assignment.Models; // Or the correct namespace
namespace manita_dotnet_assignment.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
