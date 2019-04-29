using _034.Models;
using System;
using System.Collections.Generic;

namespace _034.Repositories
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> Get();
        Book GetByID(int id);
        void Add(Book book); 
        void Delete(int id);
    }
}
