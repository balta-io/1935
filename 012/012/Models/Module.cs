using System;
using System.Collections.Generic;

namespace _012.Models
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
        public ICollection<Class> Classes { get; set; }
        public Course Course { get; set; }
    }
}
