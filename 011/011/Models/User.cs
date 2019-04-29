using System;
using System.Collections.Generic;

namespace _011.Models
{
    public partial class User
    {
        public User()
        {
            this.Books = new List<Book>();
            this.Roles = new List<Role>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
