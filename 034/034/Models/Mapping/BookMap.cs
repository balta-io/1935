using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _034.Models.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Book");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Room_Id).HasColumnName("Room_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");

            // Relationships
            this.HasRequired(t => t.Room)
                .WithMany(t => t.Books)
                .HasForeignKey(d => d.Room_Id);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Books)
                .HasForeignKey(d => d.User_Id);

        }
    }
}
