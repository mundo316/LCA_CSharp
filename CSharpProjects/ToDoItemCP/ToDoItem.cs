using System;
namespace ToDoItemCP
{
    public class ToDoItem
    {
            //private set the ID
            //info to be stored on Items

        public int Id { get; private set; }
        public string Description { get; set; }
        public string Flag { get; set; }

        public ToDoItem(string Description)
        {
            this.Description = Description;
            this.Flag = "Pending";
        }
    }
}
//POCO class
//define what a todoitem is
//items have
// -Description
// -ID#
// -item to have done flag or status
// -user sets definition/flag 
// -ID will be auto set
// -