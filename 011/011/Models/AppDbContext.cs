using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using _011.Models.Mapping;

namespace _011.Models
{
    public partial class AppDbContext : DbContext
    {
        static AppDbContext()
        {
            Database.SetInitializer<AppDbContext>(null);
        }

        public AppDbContext()
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
