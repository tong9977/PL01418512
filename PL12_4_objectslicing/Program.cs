using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL12_4_objectslicing
{
    class Program
    {
        public class Base
        {
            public String value;
        }

        public class Derived : Base
        {
            public String value2;
        }

        public static void Main(string[] args)
        {
            Base baseObj = new Base();
            Derived derivedObj = new Derived();
            derivedObj.value = "test1";
            derivedObj.value2 = "test2";

            baseObj = derivedObj;

            Console.WriteLine(baseObj.value);

            Console.ReadKey();
        }
    }
}
