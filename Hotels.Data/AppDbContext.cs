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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelReservation>().Property(j => j.Id).HasColumnName("pk_HotelReservation");

            modelBuilder.Entity<HotelReservationRooms>(entity =>
            {
                entity.HasOne(d => d.HotelReservation)
                    .WithMany(p => p.HotelReservationRooms)
                    .HasForeignKey(d => d.HotelReservationId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }

}
