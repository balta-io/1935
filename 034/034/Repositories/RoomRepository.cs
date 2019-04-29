using _034.Models;
using System.Collections.Generic;
using System.Linq;

namespace _034.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private AppDataContext _db;

        public RoomRepository(AppDataContext db)
        {
            this._db = db;
        }

        public IEnumerable<Room> Get()
        {
            return _db.Rooms.ToList();
        }

        public Room GetByID(int id)
        {
            return _db.Rooms.Find(id);
        }

        public void Add(Room room)
        {
            _db.Rooms.Add(room);
        }

        public void Delete(int id)
        {
            var room = GetByID(id);
            _db.Rooms.Remove(room);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
