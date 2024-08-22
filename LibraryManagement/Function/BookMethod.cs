using LibraryManagement.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class BookMethod
    {
        public static void printOption()
        {
            Console.WriteLine("Please choose an option");
            Console.WriteLine("1. Available Books");
            Console.WriteLine("2. Borrow a book");
            Console.WriteLine("3. Return book");
            Console.WriteLine("4. Add a new book");
            Console.WriteLine("5. Student Details");
            Console.WriteLine("6. Exit");
        }
        public static void BookListM()
        {
            Console.WriteLine("Available Books are:");

            foreach (var book in LibraryManagement.DB.BookList.books.Where(x => x.bookCount > 0))
            {
                Console.WriteLine($"Book name: {book.Title} ");
                    Console.WriteLine($"Quantity of boks:{book.bookCount}");
            };
        }
        public static void BookBorrowed()
        {
            try
            {
                List<Book> books = new List<Book>();

                int id1;
                string code;
                Console.WriteLine("Enter your student id:");
                id1 = Convert.ToInt32(Console.ReadLine());
                student std = studentList.students.Find(x => x.Id == id1);
                if (std == null)
                {
                    Console.WriteLine("please enter correct id");
                    return;
                }
                Console.WriteLine("Enter your book id:");
                code = (Console.ReadLine());


                Book book = BookList.books.Find(y => y.Code == code);
                if (book == null||book.bookCount==0)
                {
                    Console.WriteLine("book is not available");
                    return;
                }
                std.borrowedBooks.Add(book);
                book.IsAvailable = false;
                book.bookCount = book.bookCount - 1;
                Console.WriteLine($"{std.Name} has borrowed {book.Title}");
            }
            catch (Exception ex){ Console.WriteLine($"the error is of {ex.Message}");
            }


        }
        public static void StudentDetails()
        {
            Console.WriteLine("Enter the student id no. to know the details");
            int id1;
            id1=Convert.ToInt32(Console.ReadLine());
            student std = studentList.students.Find(x => x.Id == id1);
            if (std == null)
            {
                Console.WriteLine("please enter correct id");
                return;
            }
            Console.WriteLine($"Name: {std.Name}");
            Console.WriteLine($"Gender: {std.Gender}");
            Console.WriteLine($"Address: {std.Address}");
            Console.WriteLine($"Faculty: {std.Faculty}");
            Console.WriteLine($"Number: {std.PhoneNo}");
            Console.WriteLine($"semester: {std.semester}");
            Console.WriteLine("Borrowed Books:");
            foreach(var book in std.borrowedBooks)
            {
                Console.WriteLine(book.Title);  
            }
        }
        public static void BookReturn()
        {
            try
            {
                List<Book> books = new List<Book>();
                int id1;
                string code;
                Console.WriteLine("Enter your student id:");
                id1 = Convert.ToInt32(Console.ReadLine());
                student std = studentList.students.Find(x => x.Id == id1);
                if (std == null)
                {
                    Console.WriteLine("please enter correct id");
                    return;
                }
                Console.WriteLine("Enter your book id:");
                code = (Console.ReadLine());

                var stdBook = std.borrowedBooks.Find(x => x.Code == code);

                Book book = BookList.books.Find(y => y.Code == code);
                if (stdBook == null)
                {
                    Console.WriteLine($"{book.Title}  is not taken by {std.Name}");
                    return;
                }
                std.borrowedBooks.Remove(stdBook);
                book.IsAvailable = true;
                book.bookCount = book.bookCount + 1;
                Console.WriteLine($"{std.Name} has returned {book.Title}");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"The error is {ex.Message}");
            }
        }
        public void AddBook()
        {
          
            string title, author, code;
            int price, edition, bookCount;
            Console.WriteLine("Enter the Title of the Book");
            title= Console.ReadLine();
            Console.WriteLine("Enter the author of this Book");
            author= Console.ReadLine();
            Console.WriteLine("Enter the code for this Book");
            code= Console.ReadLine();
            Console.WriteLine("enter the price");
            price=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the edition of Book");
            edition=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of books you want to add");
            bookCount=Convert.ToInt32(Console.ReadLine());
            Book book1 = new Book(title, author, code,price,edition,bookCount);

            
            BookList.books.Add(book1);
            Console.WriteLine($"{title} is added");

        }
        public void WelcomeMsg()
        {
           A: Console.WriteLine("------------Welcome to our Nepathya Library----------------");
            int Option;
            try
            {
               do
                {

                 printOption();
                    Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            BookListM();

                            break;
                        case 2:
                            BookBorrowed();

                            break;
                        case 3:
                            BookReturn();

                            break;
                        case 4:
                            AddBook();

                            break;
                        case 5:
                            StudentDetails();
                            break;
                        case 6:
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }



                } while (Option != 6);

            }
            catch (Exception e) 
            {
                Console.WriteLine($"Error is {e.Message}");
                goto A;
            }
        }
    }
}
