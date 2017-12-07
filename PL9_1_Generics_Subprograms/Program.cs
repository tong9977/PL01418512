using System;
using System.Collections.Generic;
using System.Text;

namespace PL9_1_Generics_Subprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Swap<int>(ref a, ref b);
            System.Console.WriteLine(a + " " + b);

            Console.ReadKey();
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
