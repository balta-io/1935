using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using _034.Models.Mapping;

namespace _034.Models
{
    public partial class AppDataContext : DbContext
    {
        static AppDataContext()
        {
            Database.SetInitializer<AppDataContext>(null);
        }

        public AppDataContext()
            : base("Name=roombookingContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
