using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCodeFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create the database and insert student
            using (var context = new StudentContext())
            {
                var student = new Student
                {
                    Name = "Erica",
                    Age = 32
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student was successfully added.");
                Console.ReadLine();
            }
        }
    }
}
