using Microsoft.EntityFrameworkCore;
using SOALTIGADOTNET_EFCORE_SERA;

namespace SOALTIGADOTNET_API_SERA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
