using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _008.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
    }
}
