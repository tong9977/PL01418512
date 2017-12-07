using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL12_3_Inheritance_method_Base_Class
{
    class Program
    {
        class A
        {
            public virtual void Foo() { Console.WriteLine("A::Foo()"); }
        }

        class B : A
        {
            public override void Foo() {
                base.Foo();
                Console.WriteLine("B::Foo()");
            }
            public virtual void Foo2() { Console.WriteLine("B::Foo2()"); }
        }

        class Test
        {
            static void Main(string[] args)
            {
                B b = new B();
                b.Foo();

                Console.ReadKey();
            }
        }
    }
}
