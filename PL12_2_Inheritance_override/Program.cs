using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL12_2_Inheritance_override
{
    class Program
    {
        class A
        {
            public virtual void Foo() { Console.WriteLine("A::Foo()"); }
        }

        class B : A
        {
            public override void Foo() { Console.WriteLine("B::Foo()"); }
            public virtual void Foo2() { Console.WriteLine("B::Foo2()"); }
        }

        class Test
        {
            static void Main(string[] args)
            {
                A a = new A();
                B b = new B();
                a.Foo();
                b.Foo();
                b.Foo2();

                Console.ReadKey();
            }
        }
    }
}
