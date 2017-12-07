using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PL9_3_Lambda_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);


            Func<int, bool> myFunc = x => x == 5;

            bool result1 = myFunc(4); //return false
            bool result2 = myFunc(5); //return true;

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
