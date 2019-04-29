using System;
using System.Collections.Generic;

namespace _019.Models
{
    public partial class Student
    {
        public Student()
        {
            this.StudentCourses = new List<StudentCourse>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public bool Subscriber { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
