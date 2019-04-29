using _008.Domain;
using _008.Mapping;
using System.Data.Entity;

namespace _008.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            :base("AppCnnStr")
        { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
        }
    }
}
