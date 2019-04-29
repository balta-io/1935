using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _012.Models.Mapping
{
    public class StudentCourseMap : EntityTypeConfiguration<StudentCourse>
    {
        public StudentCourseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("StudentCourse");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.PurchaseDate).HasColumnName("PurchaseDate");
            this.Property(t => t.Watched).HasColumnName("Watched");

            // Relationships
            this.HasRequired(t => t.Course)
                .WithMany(t => t.StudentCourses)
                .HasForeignKey(d => d.CourseId);
            this.HasRequired(t => t.Student)
                .WithMany(t => t.StudentCourses)
                .HasForeignKey(d => d.StudentId);

        }
    }
}
