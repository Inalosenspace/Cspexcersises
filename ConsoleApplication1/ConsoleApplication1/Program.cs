using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Creating new instance and Showing it
            Book book = new Book("harry potter", "J.K. Rowling");
            Console.WriteLine(book.GetTitle());

            book.SetTitle("New Title");
            Console.WriteLine(book.GetTitle());


            Console.ReadLine();
        }
    }
}
