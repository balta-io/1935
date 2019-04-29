using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _015.Models.Mapping
{
    public class ResourceMap : EntityTypeConfiguration<Resource>
    {
        public ResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.URL)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Resource");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ClassId).HasColumnName("ClassId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.URL).HasColumnName("URL");

            // Relationships
            this.HasRequired(t => t.Class)
                .WithMany(t => t.Resources)
                .HasForeignKey(d => d.ClassId);

        }
    }
}
