using HomeApp.Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeApp.Persistence
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptionsBuilder builder) : base(builder.Options) { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Temperature> Temperatures { get; set; }
    }
}