using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Domain
{
    public class Customer
    {
        private IList<Phone> _phones;
        public Customer(string name, int age)
        {
            this.Id = 0;
            this.Name = name;
            this.Age = age;
            this.CreateDate = DateTime.Now;
            this._phones = new List<Phone>();
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime CreateDate { get; private set; }
        public ICollection<Phone> Phones { get { return _phones; } private set; }

        public void AddPhone(Phone phone)
        {
            this._phones.Add(phone);
        }
    }
}
