using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL6_1_Enumeration_Type
{
    class Program
    {
        public enum Days { Mon, Tue, Web, Thu, Fri, Sat, Sun };

        static void Main()
        {
            Days day = Days.Mon;

            if (day == Days.Mon)
            {
                Console.WriteLine("To day is monday.");
            }

            day++;

            Console.WriteLine(day.ToString());

            Console.ReadKey();
        }
    }
}
