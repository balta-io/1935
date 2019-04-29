using _024.Domain;
using System.Data.Entity;

namespace _024.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            :base("CnnStr")
        {}

        public DbSet<Customer> Customers { get; set; }
    }
}
