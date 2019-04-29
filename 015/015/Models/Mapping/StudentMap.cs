using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _015.Models.Mapping
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
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
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.Phone)
                .HasMaxLength(14);

            this.Property(t => t.Address)
                .HasMaxLength(120);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Country)
                .HasMaxLength(40);

            this.Property(t => t.ZipCode)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Student");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.Subscriber).HasColumnName("Subscriber");
        }
    }
}
