using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL9_4_Parameter_Passing_Methods_Out_mode_semantic
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthorByOutParam(out string authorName, out string bookTitle, out long publishedYear);
            Console.WriteLine("Author: {0}, Book: {1}, Year : {2}",
            authorName, bookTitle, publishedYear);
            Console.ReadKey();
        }

        static void AuthorByOutParam(out string name, out string title, out long year)
        {
            name = "Mahesh Chand";
            title = "A Programmer's Guide to ADO.NET with C#";
            year = 2001;
        }
    }
}
