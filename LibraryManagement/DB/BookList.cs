using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DB
{
    public class BookList
    {
        public static List<Book> books;
        static BookList()
        {
          
            books = new List<Book> 
            {
                new Book("C_Programming", "hari", "CP123", 500, 1, 5),
                new Book("C++","Ram","CPP123",800,2,2),
                new Book("Java","Sita","JV123",900,3, 4)

        };
        }
    }
}
