using _019.Models;
using HibernatingRhinos.Profiler.Appender.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityFrameworkProfiler.Initialize();

            using (var db = new AppDbContext())
            {
                foreach (var item in 
                    db.StudentCourses
                    .Include("Student")
                    .Include("Course").ToList())
                {
                    Console.WriteLine(String.Format("", item.Student.Name, item.Course.Title));
                }
            }

            Console.WriteLine();
        }
    }
}
