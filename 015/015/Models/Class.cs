using System;
using System.Collections.Generic;

namespace _015.Models
{
    public partial class Class
    {
        public Class()
        {
            this.Resources = new List<Resource>();
        }

        public System.Guid Id { get; set; }
        public System.Guid ModuleId { get; set; }
        public string Title { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public int Duration { get; set; }
        public string Video { get; set; }
        public virtual Module Module { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
