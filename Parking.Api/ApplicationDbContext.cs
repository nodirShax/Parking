using Microsoft.EntityFrameworkCore;

namespace Parking.Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<ParkModel> ParkModels { get; set; }
    }
}
