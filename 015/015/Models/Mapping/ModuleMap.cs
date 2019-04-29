using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _015.Models.Mapping
{
    public class ModuleMap : EntityTypeConfiguration<Module>
    {
        public ModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("Module");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.Title).HasColumnName("Title");

            // Relationships
            this.HasRequired(t => t.Course)
                .WithMany(t => t.Modules1)
                .HasForeignKey(d => d.CourseId);

        }
    }
}
