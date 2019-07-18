using System;
namespace POCO
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public string SKU;
        public string publisher;
        public double price;

        public Book(string Title, string Author, int Pages, string sku, string Publisher, double Price)
        {
            title = Title;
            author = Author;
            pages = Pages;
            SKU = sku;
            publisher = Publisher;
            price = Price;

        }


    }
}
