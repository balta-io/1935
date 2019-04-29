using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using _012.Models.Mapping;

namespace _012.Models
{
    public partial class AppDbContext : DbContext
    {
        static AppDbContext()
        {
            Database.SetInitializer<AppDbContext>(null);
        }

        public AppDbContext()
            : base("Name=andrebaltieriContext")
        {
            this.Configuration.LazyLoadingEnabled = false; 
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClassMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new ModuleMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ResourceMap());
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new StudentCourseMap());
        }
    }
}
