using System.Data.Entity;
using Treinamentos.Domain.Entities;
using Treinamentos.Infra.Mappings;

namespace Treinamentos.Infra.Contexts
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base("AppCnnStr")
        { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
        }
    }
}
