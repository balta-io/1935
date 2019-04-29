using _015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Join
            //using (var db = new AppDbContext())
            //{
            //    List<Course> courses = db.Courses.ToList();
            //    List<StudentCourse> students = db.StudentCourses.Include("Student").ToList();

            //    var q =
            //        from c in courses
            //        join s in students on c equals s.Course
            //        select new
            //        {
            //            Course = c,
            //            Student = s.Student.Name
            //        };

            //    foreach (var v in q)
            //    {
            //        Console.WriteLine(v.Course.Title + ": " + v.Student);
            //    }
            //}
            #endregion

            #region GroupBy
            //using (var db = new AppDbContext())
            //{
            //    List<StudentCourse> studentCourses = db.StudentCourses.ToList();

            //    var groups =
            //        from c in studentCourses
            //        group c by c.Course.Title into g
            //        select new { Course = g.Key, Students = g };

            //    foreach (var item in groups)
            //    {
            //        Console.WriteLine(item.Course);
            //        foreach (var student in item.Students)
            //        {
            //            Console.WriteLine(student.Student.Name);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region Order By
            using (var db = new AppDbContext())
            {
                var students = db.Students.OrderBy(x => x.Name).ToList();
                foreach (var student in students)
                {
                    Console.WriteLine(student.Name);
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
