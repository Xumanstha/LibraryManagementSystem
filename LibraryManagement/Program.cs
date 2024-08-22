using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book B1 = new Book("C_Programming","hari","CP123",500,1);
            //Book B2 = new Book(title: "C++", author:"Ram", code:"CPP123", price:800, edition:2);
            //Book B3 = new Book(title: "C++", author: "Ram", code: "CPP123", price: 800, edition: 2);
            BookMethod Book1 = new BookMethod();
            Book1.WelcomeMsg();
            Console.ReadLine();
        }
      
       
    }
}
