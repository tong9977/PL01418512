using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL6_2_Tuples_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            var result = Add_Multiply(a, b);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);
            Console.ReadKey();
        }

        private static Tuple<int, int> Add_Multiply(int a, int b)
        {
            var tuple = new Tuple<int, int>(a + b, a * b);
            return tuple;
        }
    }
}
