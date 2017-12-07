using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL7_2_assignment_statement_by_using_conditional_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 10;
            var result = x > y ? x : y;

            Console.WriteLine(result);

            if (x > y)
                result = x;
            else if (x < y)
                result = y;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
