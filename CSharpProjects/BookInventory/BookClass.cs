using System;
namespace BookInventory
{
    public class Book
    {
            //private set the ID
            //info to be stored on students
        public int Id { get; private set; }
        public string title { get; set; }
        public string author { get; set; }

        public Book(string title, string author)
        {
            this.author = author;
            this.title = title;
        }
    }
}

