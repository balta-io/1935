using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _012.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PurchaseEmail)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Ticket)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Order");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.PurchaseEmail).HasColumnName("PurchaseEmail");
            this.Property(t => t.Ticket).HasColumnName("Ticket");
            this.Property(t => t.StudentId).HasColumnName("StudentId");

            // Relationships
            this.HasRequired(t => t.Course)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.CourseId);

        }
    }
}
