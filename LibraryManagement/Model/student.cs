using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class student
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Gender {  get; set; }
        public string Address {  get; set; }
        public long PhoneNo {  get; set; }
        public string Faculty {  get; set; }
        public string semester {  get; set; }

        
        //public student(int id, string name, string gender, string address, long phoneNo)
        //{
        //    Id = id;
        //    Name = name;
        //    Gender = gender;
        //    Address = address;
        //    PhoneNo = phoneNo;
        //}
        public List<Book> borrowedBooks { get; set; }=new List<Book>();
    }
}
