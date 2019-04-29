using _005.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base("AppConnStr")
        {
            Database.SetInitializer<AppDataContext>
                (new AppDataContextInitializer());
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class AppDataContextInitializer : DropCreateDatabaseAlways<AppDataContext>
    {
        protected override void Seed(AppDataContext context)
        {
            context.Customers.Add(new Customer { Id = 1, Name = "André" });
            base.Seed(context);
        }
    }
}
