using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _012.Models.Mapping
{
    public class ClassMap : EntityTypeConfiguration<Class>
    {
        public ClassMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.Video)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Class");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ModuleId).HasColumnName("ModuleId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Views).HasColumnName("Views");
            this.Property(t => t.Likes).HasColumnName("Likes");
            this.Property(t => t.Duration).HasColumnName("Duration");
            this.Property(t => t.Video).HasColumnName("Video");

            // Relationships
            this.HasRequired(t => t.Module)
                .WithMany(t => t.Classes)
                .HasForeignKey(d => d.ModuleId);

        }
    }
}
