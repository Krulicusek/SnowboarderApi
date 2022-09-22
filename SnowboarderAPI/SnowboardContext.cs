using Microsoft.EntityFrameworkCore;
using SnowboarderModels;


namespace SnowboarderAPI
{
    public class SnowboardContext : DbContext
    {
        public SnowboardContext(DbContextOptions<SnowboardContext> options) : base(options)
        {
        }    
        public DbSet<Player> Player { get; set; }
    }
}
