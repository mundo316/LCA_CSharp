using System;
using System.Collections.Generic;

namespace ToDo
{
    class MainClass
    {
        public static void Main()
        {
            List<todoitem> ToDo = new List<todoitem>();
            Console.WriteLine("Do you want to add an item to your To Do list. Yes or No");
            string answer = Console.ReadLine().ToLower();

            while (answer == "yes")
            {
                //ask user for items individually
                Console.WriteLine("Describe the item");
                string itemdescription = Console.ReadLine();
                Console.WriteLine("Input the Due Date");
                string itemdue = Console.ReadLine();
                Console.WriteLine("Priority: Low, Med or High");
                string itempriority = Console.ReadLine();
                //add item to dictionary
                ToDo.Add(new todoitem(itemdescription, itemdue, itempriority));
                //ask the user if theyre done
                Console.WriteLine("Do you want to add an item to your To Do list. Yes or No");
                answer = Console.ReadLine().ToLower();
            }
            foreach ( todoitem item in ToDo)
            {
                Console.WriteLine($"{item.description} | {item.duedate} | {item.priority}");
            }
        }
    }

    class todoitem
    {
        public string description;
        public string duedate;
        public string priority;



        //constructor
        public todoitem(string Description, string DueDate, string Priority)
        {
            description = Description;
            duedate = DueDate;
            priority = Priority;
        }


    }
}
    


