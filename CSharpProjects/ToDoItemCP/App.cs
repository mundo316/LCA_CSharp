using System;
using System.Collections.Generic;
namespace ToDoItemCP
{
    

    public static class App
    {
        static string answer;

        static ItemRepo Repo = new ItemRepo();

        public static void add(ToDoItem description)
        {
            ToDoItem item = ConsoleUtils.AskUser();
            Repo.Add(new ToDoItem (Description));
        }

        public static void delete(int Id)
        {
            Repo.Delete(Id);
        }

        public static void markasdone(int Id)
        {
            Repo.MarkAsDone(Id);
        }

        public static void gatalldone()
        {
            Repo.GetAllDone();
        }

        public static void getallpending()
        {
            Repo.GetAllPending();
        }

        public static void getall()
        {
            Repo.GetAll();
        }

        

        public void Run()
        {
            while (true)
            {
                ConsoleUtils.AskUser.ToUpper();
                if (answer == "ADD")
                {
                    ConsoleUtils.Add();
                    add();
                    return true;
                }

                else if (answer == "DELETE")
                {
                    ConsoleUtils.Delete();
                    delete();
                    return true;
                }

                else if (answer == "VIEW")
                {
                    ConsoleUtils.View();
                    if (answer == "PENDING")
                    {
                        App.getallpending();
                        Console.WriteLine("1");
                    }
                    else if (answer == "DONE")
                    {
                        App.gatalldone();
                        Console.WriteLine("2");

                    }
                     else if (answer == "ALL")
                    {
                        App.getall();
                        Console.WriteLine("3");
                    }

                    Console.WriteLine("Press Return to Return to the Main Menu.");
                    Return == Console.ReadKey();
                    return true;
                }
            }





        }




    }
}
//driver
//ask for todoitem
//call methods from comnsole and repo
//!directly update repo

    