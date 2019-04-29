using _008.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AppDataContext db = new AppDataContext())
            {
                var customers = db.Customers.ToList();
            }
        }
    }
}
