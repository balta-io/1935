using System.Data.Entity.ModelConfiguration;
using Treinamentos.Domain.Entities;

namespace Treinamentos.Infra.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(x => x.Id);
            Property(x => x.Name)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
