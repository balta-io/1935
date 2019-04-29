using System;
using System.Linq;
using System.Collections.Generic;
using Treinamentos.Domain.Entities;
using Treinamentos.Domain.Repositories;
using Treinamentos.Infra.Contexts;
using System.Data.Entity;

namespace Treinamentos.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private AppDataContext _db;

        public CustomerRepository(AppDataContext db)
        {
            this._db = db;
        }

        public IList<Customer> GetByRange(int skip = 0, int take = 25)
        {
            return _db.Customers.OrderBy(x => x.Name).Skip(skip).Take(take).ToList();
        }

        public Customer GetById(int id)
        {
            return _db.Customers.Find(id);
        }

        public void Save(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _db.Entry<Customer>(customer).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = GetById(id);
            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
