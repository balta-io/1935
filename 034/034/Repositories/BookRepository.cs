using _034.Models;
using System.Collections.Generic;
using System.Linq;

namespace _034.Repositories
{
    public class BookRepository : IBookRepository
    {
        private AppDataContext _db;

        public BookRepository(AppDataContext db)
        {
            this._db = db;
        }

        public IEnumerable<Book> Get()
        {
            return _db.Books.ToList();
        }

        public Book GetByID(int id)
        {
            return _db.Books.Find(id);
        }

        public void Add(Book book)
        {
            _db.Books.Add(book);
        }

        public void Delete(int id)
        {
            var book = GetByID(id);
            _db.Books.Remove(book);
        }

        public void Dispose()
        {
            //_db.Dispose();
        }
    }
}
