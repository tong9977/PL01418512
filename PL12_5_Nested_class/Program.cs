using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL12_5_Nested_class
{
    class A
    {
        public int _v1;

        public class B
        {
            public int _v2;
        }
    }

    class Program
    {
        static void Main()
        {
            A a = new A();
            a._v1++;
            Console.WriteLine(a._v1);

            A.B ab = new A.B();
            ab._v2++;
            Console.WriteLine(ab._v2);

            Console.ReadKey();
        }
    }
}
