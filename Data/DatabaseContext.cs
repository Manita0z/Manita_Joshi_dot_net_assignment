using Microsoft.EntityFrameworkCore;
using manita_dotnet_assignment.Models;

namespace manita_dotnet_assignment.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
    }
}
