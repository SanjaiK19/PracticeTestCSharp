using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    class Book
    {
        public string Id;
        public string Title;

        private bool available = true;
        public Book(string id,string title)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Invalid details");
            Id = id;
            Title = title;
        }
        public void Borrow()
        {
            if (available)
            {
                available = false;
                Console.WriteLine(Title + " borrowed");
            }
            else
            {
                Console.WriteLine("Book unavailable");
            }
        }
        public void Return()
        {
            if (!available)
            {
                available = true;
                Console.WriteLine(Title + " returned");
            }
            else
            {
                Console.WriteLine("Book already available");
            }
        }
    }
    public class LibraryBookModel
    {
        public static void Main()
        {
            Book b1 = new Book("Book1", "C# book");
            Book b2 = new Book("Book2", "DotNet book");

            b1.Borrow();
            b1.Borrow();
            b1.Return();

            b2.Borrow();
        }
    }
}
