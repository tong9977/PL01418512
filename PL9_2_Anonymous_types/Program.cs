using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PL9_2_Anonymous_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new { Amount = 108, Message = "Hello" };

            Console.WriteLine(v.Amount + v.Message);

            Console.ReadKey();
        }
    }
}
