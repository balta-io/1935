using System;
using System.Collections.Generic;

namespace _020.Models
{
    public partial class Customer
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string country { get; set; }
    }
}
