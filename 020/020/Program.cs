using _020.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColdWarm();
            //Cache();
            //ComposingQuery();
            //AutoCompiledQueries();
            NoTrackingQueries();

            Console.ReadKey();
        }

        public static void ColdWarm()
        {
            using (var db = new DataAccessTestContext())
            {
                DateTime startDate1 = DateTime.Now;
                var customers = db.Customers.ToList();
                DateTime endDate1 = DateTime.Now;
                Console.WriteLine("Execução 1: {0}", (endDate1 - startDate1));

                customers = null;

                DateTime startDate2 = DateTime.Now;
                customers = db.Customers.ToList();
                DateTime endDate2 = DateTime.Now;
                Console.WriteLine("Execução 2: {0}", (endDate2 - startDate2));
            }

            using (var db = new DataAccessTestContext())
            {
                DateTime startDate1 = DateTime.Now;
                var customers = db.Customers.ToList();
                DateTime endDate1 = DateTime.Now;
                Console.WriteLine("Execução 3: {0}", (endDate1 - startDate1));
            }
        }

        public static void Cache()
        {
            using (var db = new DataAccessTestContext())
            {
                db.Configuration.AutoDetectChangesEnabled = false;
                DateTime startDate1 = DateTime.Now;
                var customers = db.Customers.Find(1);
                DateTime endDate1 = DateTime.Now;
                Console.WriteLine("AutoDetectChangesEnabled = false: {0}", (endDate1 - startDate1));
            }

            using (var db = new DataAccessTestContext())
            {
                db.Configuration.AutoDetectChangesEnabled = true;
                DateTime startDate1 = DateTime.Now;
                var customers = db.Customers.Find(1);
                DateTime endDate1 = DateTime.Now;
                Console.WriteLine("AutoDetectChangesEnabled = true: {0}", (endDate1 - startDate1));
            }
        }

        public static void QueryPlan()
        {
            using (var db = new DataAccessTestContext())
            {
                var query = from customer in db.Customers
                            where customer.id == 1
                            select new
                            {
                                customer.id,
                                customer.first_name
                            };

                ObjectQuery oQuery = query as ObjectQuery;
                oQuery.EnablePlanCaching = false;
            }
        }

        public static void CompiledQuery()
        {
            using (var db = new DataAccessTestContext())
            {
                //var customers =
                //    System.Data.Linq.CompiledQuery
                //    .Compile<DataAccessTestContext, string, IQueryable<Customer>>(
                //(DataAccessTestContext dbc, string name) => dbc.Customers.Where(p => p.first_name == name));

                //customers.Invoke(db, "André Baltieri").ToList();
            }
        }

        public static void ComposingQuery()
        {
            using (var db = new DataAccessTestContext())
            {
                IQueryable<Customer> query = db.Customers.AsQueryable();
                query = query.Where(x => x.first_name.StartsWith("A"));
                query = query.OrderBy(x => x.first_name);
                query = query.Skip(0);
                query = query.Take(100);

                foreach (var customer in query.ToList())
                {
                    Console.WriteLine(customer.first_name + " " + customer.last_name);
                }
            }
        }

        public static void AutoCompiledQueries()
        {
            using (var db = new DataAccessTestContext())
            {
                // LOUCURA!!!
                int[] ids = new int[10];
                var query = db.Customers.Where(x => ids.Contains(x.id));
                var results = query.ToList();

                foreach (var customer in results)
                {
                    Console.WriteLine(customer.first_name + " " + customer.last_name);
                }
            }
        }

        public static void NoTrackingQueries()
        {
            using (var db = new DataAccessTestContext())
            {
                DateTime startTime = DateTime.Now;
                var query = from c in db.Customers.AsNoTracking()
                            select c;
                var customers = query.ToList();
                DateTime endTime = DateTime.Now;
                Console.WriteLine("AsNoTracking habilitado: {0}", (endTime - startTime));
                Console.WriteLine("Objetos recuperados: {0}", customers.Count);
            }

            Console.WriteLine();

            using (var db = new DataAccessTestContext())
            {
                DateTime startTime = DateTime.Now;
                var query = from c in db.Customers
                            select c;
                var customers = query.ToList();
                DateTime endTime = DateTime.Now;
                Console.WriteLine("AsNoTracking deshabilitado: {0}", (endTime - startTime));
                Console.WriteLine("Objetos recuperados: {0}", customers.Count);
            }
        }
    }
}
