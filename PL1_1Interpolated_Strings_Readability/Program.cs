using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace PL1_1Interpolated_Strings_Readability
{
    class Program
    {
        public static void Main()
        {
            var name = "Horace";
            var age = 34;
            var s1 = $"He asked, \"Is your name {name}?\", but didn't wait for reply.";
            Console.WriteLine(s1);

            var s2 = $"{name} is {age:D3} year{(age == 1 ? "" : "s")} old.";
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
