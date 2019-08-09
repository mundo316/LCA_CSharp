using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BookInventory
{
    public class BookContext : DbContext
    {
        //corresponds to table in database
        public DbSet<Book> books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //targets directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            //gets base directory for the priject
            //not sure if this parent thing works
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            //add books.db to project directory
            string Databasefile = Path.Combine(ProjectBase.FullName,"Books.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :"+DatabaseFile);

            optionsBuilder.UseSqlite("Data Source=" + Databasefile);


        }




    }
}
