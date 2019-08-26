using System;
using System.Linq;
using System.Collections.Generic;

namespace ToDoItemCP
{
    public class ItemRepo
    {
        //public ItemContext Context;
        //public ToDoItem Get{int Id};
        public List<ToDoItem> ToDoList = new List<ToDoItem>();


        public ItemContext Context;
        //connects to context
        public ItemRepo()
        {
            Context = new ItemContext();
            Context.Database.EnsureCreated();
        }


        //public ToDoItem Get(int id)
        //{
        //    Context = new ItemContext();
        //    return Context.Items.Find(id);
        //    //return Context.Items.ToList();
        //}  

        public List<ToDoItem> GetAll()
        {
            return Context.Items.ToList();
        }

        public List<ToDoItem> GetAllDone()
        {
            return Context.Items.ToList();
        }

        public List<ToDoItem> GetAllPending()
        {
            return Context.Items.ToList();
            //ConsoleUtils.PrintTable(ToDoList);


        }

        public void Add(ToDoItem item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public void MarkAsDone(int Id)
        {
            ToDoItem Item = Context.Items.Find(Id);
            Item.Flag = "Complete";
            Context.Update(Item);
            Context.SaveChanges();
        }

        public void Delete(int Id)
        {
            ToDoItem Item = Context.Items.Find(Id);
            Context.Remove(Item);
            Context.SaveChanges();
        }

    
    }
}    
            //use linq here/???
            //talks to database-
            //item context instance-
            //add()-
            //update()-
            //delete()

            //!!display or accept info from user
        // change the return type to a List<ToDoItem> and then on your return statement add .ToList()
