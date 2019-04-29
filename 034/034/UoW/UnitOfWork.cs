using _034.Models;

namespace _034.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDataContext _context;

        public UnitOfWork(AppDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
