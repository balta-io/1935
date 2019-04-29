using System;
using System.Collections.Generic;

namespace _034.Models
{
    public partial class Book
    {
        public System.Guid Id { get; set; }
        public int Status { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public System.Guid Room_Id { get; set; }
        public System.Guid User_Id { get; set; }
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
    }
}
