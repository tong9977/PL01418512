using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PL11_1_Data_Abstraction
{
    class Person
    {
        public string name;

        public Person()
        {
            name = "unknown";
        }

        public Person(string nm)
        {
            name = nm;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetName("Rachakrit Monyanon");
            Console.WriteLine(p.GetName());

            Console.ReadKey();
        }
    }
}

