using _010.Data;
using _010.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BlogDataContext db = new BlogDataContext())
            {
                Blog blog = new Blog
                {
                    BlogId = 0,
                    Name = "New blog",
                    Url = "teste"
                };
                db.Blogs.Add(blog);
                db.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
