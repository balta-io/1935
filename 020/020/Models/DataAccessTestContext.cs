using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using _020.Models.Mapping;

namespace _020.Models
{
    public partial class DataAccessTestContext : DbContext
    {
        static DataAccessTestContext()
        {
            Database.SetInitializer<DataAccessTestContext>(null);
        }

        public DataAccessTestContext()
            : base("Name=DataAccessTestContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
        }
    }
}
