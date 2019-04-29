using _008.Domain;
using System.Data.Entity.ModelConfiguration;

namespace _008.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");

            HasKey(x => x.Id);
            Property(x => x.Birthday);
            Property(x => x.IsActive);
            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.Salary);
        }
    }
}
