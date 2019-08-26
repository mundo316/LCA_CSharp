using System;
using System.Collections.Generic;


//user enters items
//only class with a cw() or cr()
//!interact with repo
//!interact with database

namespace ToDoItemCP
{
    public class ConsoleUtils
    {
        public ToDoItem item;

        
        //public ConsoleUtils()
        //{
        //   //constructor 
        //}
        

        public static string AskUser()
        {

            //do
            //{ //loop asking the user what they want to do

                Console.WriteLine("Would you like to ADD to, DELETE from, or VIEW your To Do List? Choose one or enter DONE");
                string answer = Console.ReadLine();

                return answer;
        }

        public static string Add()
        {
            //addtoDB()
            Console.WriteLine("Enter a To-Do Item.");

            Console.WriteLine("Enter something into your To Do list.");
            string Description = Console.ReadLine();
            return Description;
        }

        public static string Delete()
        {
            int chg;

            Console.WriteLine("Which item No. would you like to remove?");
            string IdSelection = Console.ReadLine();
            try
            {
                chg = Int32.Parse(IdSelection);
                return IdSelection;

            }
            catch
            {
                Console.WriteLine("Please choose an actual option");
                IdSelection = "0"; 
                Console.ReadKey();
            }

            return IdSelection;
        }

        public static string View()
        {
            Console.WriteLine("Would you like to view the PENDING items, DONE items or ALL items?");
            return Console.ReadLine().ToUpper();
            //switch (viewanswer)
            //{
            //    case "PENDING":
            //        return "PENDING";
            //    case "DONE":
            //        return "done";
            //    case "ALL":
            //        return "all";
            //    default:
            //        Console.WriteLine("Error! try again.");
            //        return null;       
            //}
        }

        public static void PrintTable(List<ToDoItem> List)
        {
            foreach (var ToDoItem in List)
            {
                Console.WriteLine("|--ID--|-----DESCRIPTION------|--FLAG--");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"{ToDoItem.Id} | {ToDoItem.Description} | {ToDoItem.Flag}");   
            }
        }
    }
}



//    {
//        Console.WriteLine(App.Getall());
//    }
//   else
//    {
//        Console.WriteLine("ERROR please try again.");
//        return answer false;//or something that can tell the loop to go again
//    }





//    if (answer == "ADD")
//    {
//        //addtoDB()
//        Console.WriteLine("Enter a To-Do Item.");

//        Console.WriteLine("Enter something into your To Do list.");
//        string Description = Console.ReadLine();


//        return Description;
//    }

//    int chg;

//    if (answer == "DELETE")
//    {
//        Console.WriteLine("Which item No. would you like to remove?");
//        string selection = Console.ReadLine();
//        try
//        {
//            chg = Int32.Parse(selection);

//        }
//        catch
//        {
//            Console.WriteLine("Please choose an option");
//            selection = "0";
//            Console.ReadKey();
//        }

//        //delete from db()
//    }
//    if (answer == "VIEW")
//    {
//        Console.WriteLine(App.Getall());
//    }
//   else
//    {
//        Console.WriteLine("ERROR please try again.");
//        return answer false;//or something that can tell the loop to go again
//    }
//} while (true);//while answer doesnt equal false???