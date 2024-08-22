using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public string Title{get;set;}
        public string Author { get;set;}
        public string Code { get;set;}
        public int Price { get;set;}
        public bool IsAvailable { get;set;}
        public int Edition {  get;set;}
        public int bookCount { get; set; }
        public Book(string title, string author, string code, int price, int edition, int bookCount)
        {
            Title = title;
            Author = author;
            Code = code;
            Price = price;
            IsAvailable = true;
            Edition = edition;
            this.bookCount = bookCount;
        }
    }

}
