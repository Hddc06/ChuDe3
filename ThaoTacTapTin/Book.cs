using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ThaoTacTapTin
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int YearPublished { get; set; }

        public Book()
        {

        }

        public Book(string isbn, string title, string author,
            decimal price, int yearPublished)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.YearPublished = yearPublished;
        }
    }
}
