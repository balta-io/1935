using System;
using System.Collections.Generic;

namespace _015.Models
{
    public partial class StudentCourse
    {
        public System.Guid Id { get; set; }
        public System.Guid StudentId { get; set; }
        public System.Guid CourseId { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public bool Watched { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
