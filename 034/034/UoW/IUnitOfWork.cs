using _034.Repositories;
using System;

namespace _034.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
