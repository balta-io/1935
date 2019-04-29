using _024.Data;
using _024.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AppDataContext db = new AppDataContext())
            {
                var customer = new Customer
                {
                    Birthday = DateTime.Now,
                    Id = 0,
                    Name = "Algum nome com mais de dez caracteres"
                };

                try
                {
                    db.Customers.Add(customer);
                    //db.Customers.Where(x => x.Name == "André").First(); // Se  não encontrara gera exception
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
            }

        }
    }
}
