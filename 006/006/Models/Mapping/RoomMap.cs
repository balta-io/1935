using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _006.Models.Mapping
{
    public class RoomMap : EntityTypeConfiguration<Room>
    {
        public RoomMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("Room");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Title).HasColumnName("Title");
        }
    }
}
