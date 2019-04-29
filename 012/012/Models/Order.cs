using System;
using System.Collections.Generic;

namespace _012.Models
{
    public partial class Order
    {
        public System.Guid Id { get; set; }
        public System.Guid CourseId { get; set; }
        public System.DateTime Date { get; set; }
        public string PurchaseEmail { get; set; }
        public string Ticket { get; set; }
        public Nullable<System.Guid> StudentId { get; set; }
        public Course Course { get; set; }
    }
}
