using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL11_2_Constructors_Destructors
{
    class Program
    {
        public class Car
        {
            private string color = "";

            public Car(string color)
            {
                this.color = color;
                Console.WriteLine("Constructor with color parameter called!");
            }

            ~Car()
            {
                Console.WriteLine("Out..");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            Car c = new Car("blue");
            Console.ReadKey();
        }
    }

}
