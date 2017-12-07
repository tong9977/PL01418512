using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL8_2_Logically_controlled_loops_pretest_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 2)
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = 1;

                i++;

                while (j < 2)
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                }
            }

            Console.ReadKey();
        }
    }
}
