using Hotels.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<HotelReservation> HotelReservation { get; set; }
        public DbSet<HotelReservationRooms> HotelReservationRooms { get; set; }
    }
}