using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace ToDoItemCP

//uses MSEntityFWCore to communicate between the SQLite DB and the program

{
    public class ItemContext : DbContext
    { 
            //corresponds to table in database
            public DbSet<ToDoItem> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //targets directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            //gets base directory for the project
            //not sure if this parent thing works
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            //add books.db to project directory
            string Databasefile = Path.Combine(ProjectBase.FullName, "ToDoItems.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :"+DatabaseFile);

            optionsBuilder.UseSqlite("Data Source=" + Databasefile);
        }
    } 
    
}
