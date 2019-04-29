using _002.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _002.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Book");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Room);
        }

    }
}
