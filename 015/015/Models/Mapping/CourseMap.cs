using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _015.Models.Mapping
{
    public class CourseMap : EntityTypeConfiguration<Course>
    {
        public CourseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Summary)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.Description)
                .IsRequired();

            this.Property(t => t.PayPal)
                .HasMaxLength(20);

            this.Property(t => t.EventUrl)
                .HasMaxLength(200);

            this.Property(t => t.RoomUrl)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Course");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Tag).HasColumnName("Tag");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Duration).HasColumnName("Duration");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.PublishDate).HasColumnName("PublishDate");
            this.Property(t => t.Modules).HasColumnName("Modules");
            this.Property(t => t.Classes).HasColumnName("Classes");
            this.Property(t => t.PayPal).HasColumnName("PayPal");
            this.Property(t => t.EventUrl).HasColumnName("EventUrl");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.OnlineNow).HasColumnName("OnlineNow");
            this.Property(t => t.RoomUrl).HasColumnName("RoomUrl");
        }
    }
}
