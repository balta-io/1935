using _011.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room
            {
                Id = Guid.NewGuid(),
                Title = "Sala Nova",
                Status = 1,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(5)
            };
            var book = new Book
            {
                Id = Guid.NewGuid(),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(5),
                Room = room,
                Status = 1,
                User = new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Andre",
                    Email = "andrebaltier@hotmail.com",
                    Password = "xpto"
                }
            };

            using (AppDbContext db = new AppDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }
    }
}
