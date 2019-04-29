using System;
using System.Collections.Generic;

namespace _015.Models
{
    public partial class Module
    {
        public Module()
        {
            this.Classes = new List<Class>();
        }

        public System.Guid Id { get; set; }
        public System.Guid CourseId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual Course Course { get; set; }
    }
}
