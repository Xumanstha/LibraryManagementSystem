using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DB
{
    public class studentList
    {
        public static List<student> students = new List<student>()
        {
            new student
            {
                Id=1,
                Name="Suman",
                Gender="Male",
                Address="Devinagar,Butwal",
                PhoneNo=975654545,
                Faculty="BScCSIT",
                semester="2nd",
                //borrowedBooks=new List<Book>
                //{
                //    BookList.books[0]
                //}
            },
            new student
            {
                Id =2,
                Name="Sita",
                Gender="Female",
                Address="Microsoft",
                PhoneNo=897987979,
                Faculty="BCA",
                semester="3rd",


            },
            new student
            {
                Id=3,
                Name="saroj",
                Gender="Male",
                Address="Divertole",
                PhoneNo=9754565656,
                Faculty="BScCSIT",
                semester="2nd"
            },
            new student
            {
                Id=4,
                Name="Bikram",
                Gender="Male",
                Address="Arghakhanchi",
                PhoneNo=987897978,
                Faculty="BCA",
                semester="2nd"
            }
        };
    }
}
