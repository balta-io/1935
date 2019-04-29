using _010.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.Data
{
    public class BlogDataContext : DbContext
    {
        public BlogDataContext()
            : base("BlogConnectionString")
        { }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
              .Entity<Blog>()
              .MapToStoredProcedures(s => s.Insert(i => i.HasName("insert_blog")));
        }
    }
}
