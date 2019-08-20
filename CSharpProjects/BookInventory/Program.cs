using System;
using System.Collections.Generic;

namespace BookInventory
{
    class Program
    {
        static void Main(string[] args)
        {

            query();
            ////instatiate context
            //BookContext context = new BookContext();
            ////checks if table exists and creates it if it doesnt
            //context.Database.EnsureCreated();

            ////ask user how they want to interact with database
            //Console.WriteLine("BOOK INVENTORY DATABASE");
            //Console.WriteLine("What would you like to do?");
            //Console.WriteLine("Type ADD to add a book to the database");
            //Console.WriteLine("Type !!DELETE!! to delete a book");
            //Console.WriteLine("Type VIEW to view database table");
            //string command = Console.ReadLine();



            ////add()
            //if (command == "ADD")
            //{
            //    //asks user to add book
            //    Console.WriteLine("Enter Title and Author of a book.");
            //    Console.WriteLine("Enter Title");
            //    string title = Console.ReadLine();
            //    Console.WriteLine("Enter Author");
            //    string author = Console.ReadLine();

            //    string Bookinfo = title + author;

            //    context.books.Add(new Book(title, author));

            //    context.SaveChanges();

            //    Console.WriteLine("Book Added to Database");
            //}
            ////delete()
            //if (command == "!!DELEETE!!")
            //{
            //    //deletebook();
            //    Console.WriteLine("Input the ID number of the book you wish to delete");
            //    context.books.RemoveRange();
            //}
            ////view table
            //if (command == "VIEW")
            //{

            //    foreach (Book s in context.books)
            //    {
            //        Console.WriteLine("The Current List of books are: ");

            //        Console.WriteLine("{0} - {1} by {2}",
            //             s.Id, s.title, s.author);
            //    }
            //}
            ////error
            //else
            //{
            //    Console.WriteLine("ERROR INPUT VALID COMMAND");
            //}

        }

        public static void query()
        {
            do
            {
                //instatiate context
                BookContext context = new BookContext();
                //checks if table exists and creates it if it doesnt
                context.Database.EnsureCreated();

                //ask user how they want to interact with database
                Console.WriteLine("BOOK INVENTORY DATABASE");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Type ADD to add a book to the database");
                Console.WriteLine("Type !!DELETE!! to delete a book");
                Console.WriteLine("Type VIEW to view database table");
                Console.WriteLine("Type !!STOP!! to stop program");
                string command = Console.ReadLine();



                //add()
                if (command == "ADD")
                {
                    //asks user to add book
                    Console.WriteLine("Enter Title and Author of a book.");
                    Console.WriteLine("Enter Title");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter Author");
                    string author = Console.ReadLine();

                    string Bookinfo = title + author;

                    context.books.Add(new Book(title, author));

                    context.SaveChanges();

                    Console.WriteLine("Book Added to Database");
                }
                //delete()
                if (command == "!!DELEETE!!")
                {
                    //deletebook();
                    Console.WriteLine("Input the ID number of the book you wish to delete");
                    context.books.RemoveRange();
                }
                //view table
                if (command == "VIEW")
                {

                    foreach (Book s in context.books)
                    {
                        Console.WriteLine("The Current List of books are: ");

                        Console.WriteLine("{0} - {1} by {2}",
                             s.Id, s.title, s.author);
                    }
                }
                if (command == "!!STOP!!")
                {
                    break;
                }
                //error
                else
                {
                    Console.WriteLine("ERROR INPUT VALID COMMAND");
                }

            

            } while (true);
        }

    }
    //INSTRUCTIONS
    //Your program should ask the user to enter the title and the author for the book they wish to add.
    //Your program should add the book to the database.
    //Your program should print all books in the database.
    //As you run your program your database of books should grow.
}
