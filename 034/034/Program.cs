using _034.Models;
using _034.Repositories;
using _034.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDataContext context = new AppDataContext();
            IUnitOfWork uow = new UnitOfWork(context);
            IBookRepository bookRepository = new BookRepository(context);
            IRoomRepository roomRepository = new RoomRepository(context);

            var books = bookRepository.Get();
            var rooms = roomRepository.Get();
            var room = new Room
            {
                Id = Guid.NewGuid(),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(2),
                Status = 1,
                Title = "Sala 01"
            };
            roomRepository.Add(room);
            uow.Commit();
        }
    }
}
