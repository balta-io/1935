using System;
using System.Collections.Generic;

namespace _034.Models
{
    public partial class Room
    {
        public Room()
        {
            this.Books = new List<Book>();
        }

        public System.Guid Id { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int Status { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
