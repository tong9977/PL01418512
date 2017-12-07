using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL8_1_Counter_Controlled_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }

            Console.ReadKey();
        }
    }
}
