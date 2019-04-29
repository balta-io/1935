using _012.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lazy Loading
            // Habilitado/desabilitado utilizando Virtual antes da propriedade
            // public virtual ICollection<StudentCourse> StudentCourses { get; set; }
            //using (AppDbContext db = new AppDbContext())
            //{
            //    foreach (var student in db.Students)
            //    {
            //        Console.WriteLine(student.Name);
            //        foreach (var course in student.StudentCourses)
            //        {
            //            Console.WriteLine("\t" + course.Course.Title);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region Eager Loading
            // Habilitado utilizando include
            //using (AppDbContext db = new AppDbContext())
            //{
            //    foreach (var student in db.Students.Include("StudentCourses").Include("StudentCourses.Course"))
            //    {
            //        Console.WriteLine(student.Name);
            //        foreach (var course in student.StudentCourses)
            //        {
            //            Console.WriteLine("\t" + course.Course.Title);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region Explicitly Loading
            using (AppDbContext db = new AppDbContext())
            {
                // Carrega todos os alunos 
                var students = db.Students
                    .Include("StudentCourses")
                    .Include("StudentCourses.Course")
                    .ToList();

                // Carrega um aluno e todos seus cursos
                var student = db.Students
                    .Include("StudentCourses")
                    .Include("StudentCourses.Course")
                    .Where(x => x.Name == "André Baltieri")
                    .FirstOrDefault();

                // Atualiza um estudante
                //db.Entry<Student>(student).State = 
                //    System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                // Remove um estudante
                //db.Students.Remove(student);
                //db.SaveChanges();

                // Conta quantos cursos o aluno tem  
                var studentsCourseCount = db.Entry(student)
                                      .Collection(b => b.StudentCourses)
                                      .Query()
                                      .Count();
                // Evitar
                // var courseCount = student.StudentCourses.Count();
            }
            #endregion

            Console.ReadKey();
        }
    }
}
