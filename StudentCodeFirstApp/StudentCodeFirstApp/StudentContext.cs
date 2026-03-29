using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentCodeFirstApp
{
    public class StudentContext : DbContext //inheriting from dbcontext
    {
        // Constructor that calls the base DbContext constructor and passes the name
        // of the connection string ("StudentDataBase").
        public StudentContext() : base("StudentDataBase") { }

        //student table in DB
        public DbSet<Student> Students { get; set; }

    }
}
