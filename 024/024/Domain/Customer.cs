using System;
using System.ComponentModel.DataAnnotations;

namespace _024.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
