using System;
using System.Collections.Generic;

namespace ToDoItemCP
{
    public class App
    {

        //string answer;

        ItemRepo Repo = new ItemRepo();

        public void add()
        {
            var item = ConsoleUtils.AskUser();
            Repo.Add(new ToDoItem(item));
        }

        public void delete(int Id)
        {
            Repo.Delete(Id);
        }

        public void markasdone(int Id)
        {
            Repo.MarkAsDone(Id);
        }

        public void gatalldone()
        {
            Repo.GetAllDone();
        }

        public void getallpending()
        {
            Repo.GetAllPending();
        }

        public void getall()
        {
            Repo.GetAll();
        }



        public bool StartApp()
        {
            while (true)
            {
                string answer = ConsoleUtils.AskUser().ToUpper();
                switch (answer)
                {
                    case "ADD":
                        string newToDoItem = ConsoleUtils.Add();
                        Repo.Add(new ToDoItem(newToDoItem));
                        break;
                    case "DELETE":
                        var deleteItem = ConsoleUtils.Delete();
                        Repo.Delete(Convert.ToInt32(deleteItem));
                        break;
                    case "VIEW":
                        var answer2 = ConsoleUtils.View().ToUpper();

                        if (answer2 == "PENDING")
                        {
                            var pending = Repo.GetAllPending();
                            ConsoleUtils.PrintTable(pending);
                        }
                        else if (answer2 == "DONE")
                        {
                            var done = Repo.GetAllDone();
                            ConsoleUtils.PrintTable(done);

                        }
                        else if (answer2 == "ALL")
                        {
                            var all = Repo.GetAll();
                            ConsoleUtils.PrintTable(all);
                        }
                        break;

                    default:
                        break;
                }

                //if (answer == "ADD")
                //{
                    
                //    //add(newToDoItem);
                //    //return true;
                //}

                //else if (answer == "DELETE")
                //{
                    
                //    //return true;
                //}

                //else if (answer == "VIEW")
                //{
                    
                //}

                else if (answer == "DONE")
                {
                    return false;
                }

                else
                {
                    Console.WriteLine("Press Return to Return to the Main Menu.");
                    Console.ReadKey();
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

    