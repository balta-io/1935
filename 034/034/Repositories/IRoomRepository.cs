using _034.Models;
using System;
using System.Collections.Generic;

namespace _034.Repositories
{
    public interface IRoomRepository : IDisposable
    {
        IEnumerable<Room> Get();
        Room GetByID(int id);
        void Add(Room room);
        void Delete(int id);
    }
}
