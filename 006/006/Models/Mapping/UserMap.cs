using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _006.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
        }
    }
}
