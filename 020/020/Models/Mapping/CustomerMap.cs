using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _020.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.first_name)
                .HasMaxLength(50);

            this.Property(t => t.last_name)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.country)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Customer");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.first_name).HasColumnName("first_name");
            this.Property(t => t.last_name).HasColumnName("last_name");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.country).HasColumnName("country");
        }
    }
}
