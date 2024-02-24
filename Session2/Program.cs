using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Session2
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.InsertPhone("John", "123456789");
            phoneBook.InsertPhone("Alice", "987654321");
            phoneBook.InsertPhone("Bob", "456789123");
            phoneBook.InsertPhone("Alice", "111222333");
            phoneBook.Sort();

            phoneBook.InsertPhone("Bob");

            phoneBook.SearchPhone("Alice");

            phoneBook.UpdatePhone("Alice", "999888777");
            phoneBook.SearchPhone("Alice");
        }
    }
}
