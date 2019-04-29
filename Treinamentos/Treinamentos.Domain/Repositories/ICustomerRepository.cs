using System;
using System.Collections.Generic;
using Treinamentos.Domain.Entities;

namespace Treinamentos.Domain.Repositories
{
    public interface ICustomerRepository : IDisposable
    {
        IList<Customer> GetByRange(int skip = 0, int take = 25);
        Customer GetById(int id);
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
    }
}
