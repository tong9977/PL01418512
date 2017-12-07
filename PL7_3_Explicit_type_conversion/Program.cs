using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL7_3_Explicit_type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 75;

            float f = (float) i;
            Console.WriteLine(f.ToString());

            double d = 2345.7652;
            Console.WriteLine(d.ToString());

            int i2 = (int) d;
            Console.WriteLine(i2.ToString());

            Console.ReadKey();
        }
    }
}
