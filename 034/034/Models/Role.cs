using System;
using System.Collections.Generic;

namespace _034.Models
{
    public partial class Role
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
