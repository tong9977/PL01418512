using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL7_1_overloaded_operator
{
    class Fraction
    {
        int num, den;
        public Fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den,
               a.den * b.den);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }
        //แสดงผล
        public void Print()
        {
            Console.WriteLine(this.num.ToString() + " / " + this.den.ToString());
        }
 
        public static implicit operator double(Fraction f)
        {
            return (double)f.num / f.den;
        }
    }

    class Test
    {
        static void Main()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(3, 7);
            Fraction c = a + b;
            c.Print();
            c = a * b;
            c.Print();
            Console.ReadKey();
        }
    }
}
