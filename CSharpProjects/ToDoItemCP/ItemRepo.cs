using System;
using System.Linq;
using System.Collections.Generic;

namespace ToDoItemCP
{
    public class ItemRepo
    {
        public ItemContext Context;
        public ToDoItem get(int Id)
        {
            return Context.Items.Where(x => x.Id == Id).FirstOrDefault();
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return Context.Items;
        }

        public IEnumerable<ToDoItem> GetAllDone()
        {
            return Context.Items.Where(item => item.Flag == "Done");
        }

        public IEnumerable<ToDoItem> GetAllPending()
        {
            return Context.Items.Where(item => item.Flag == "Pending");
        }

        public void Add(ToDoItem item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public void MarkAsDone(int Id)
        {
            ToDoItem Item = get(Id);
            Item.Flag = "Complete";
            Context.Update(Item);
            Context.SaveChanges();
        }

        public void Delete(int Id)
        {
            ToDoItem Item = get(Id);
            Context.Remove(Item);
            Context.SaveChanges();
        }

        public ItemRepo()
        {
            Context = new ItemContext();
            //use linq here/???
            //talks to database-
            //item context instance-
            //add()-
            //update()-
            //delete()

            //!!display or accept info from user



        }
    }
}
