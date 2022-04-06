using Microsoft.EntityFrameworkCore;
using DAB_ASS2.Models;


namespace DAB_ASS2
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=127.0.0.1,1433;Database=Municipality1;User ID=SA;Password=ZyurnYNmhXBP37Jdpr7a;"
                );

        }


        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Society> Societies { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Chairman> Chairmen { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationAccess> LocationAccesses { get; set; }
        public DbSet<KeyResponsible> keyResponsibles { get; set; }


    }
}






