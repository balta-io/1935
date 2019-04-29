using System;
using System.Collections.Generic;

namespace _015.Models
{
    public partial class Course
    {
        public Course()
        {
            this.StudentCourses = new List<StudentCourse>();
            this.Orders = new List<Order>();
            this.Modules1 = new List<Module>();
        }

        public System.Guid Id { get; set; }
        public string Tag { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public int Duration { get; set; }
        public int Type { get; set; }
        public System.DateTime PublishDate { get; set; }
        public int Modules { get; set; }
        public int Classes { get; set; }
        public string PayPal { get; set; }
        public string EventUrl { get; set; }
        public int Level { get; set; }
        public bool OnlineNow { get; set; }
        public string RoomUrl { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Module> Modules1 { get; set; }
    }
}
