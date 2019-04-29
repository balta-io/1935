using _002.Entities;
using _002.Mapping;
using System.Data.Entity;

namespace _002.Data
{
    public class RoomBookingDataContext : DbContext
    {
        public RoomBookingDataContext()
            : base("RoomBookingConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new RoomMap());
        }
    }
}
