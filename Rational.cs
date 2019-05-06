using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class Rational
    {
        int numerator;
        int denominator;

        public Rational(int x, int y) // the signature of method is different
        {
            numerator = x;
            denominator = y;
        }
        public Rational() // the signature of method is different
        {
            numerator = 0;
            denominator = 0;
        }
        public void Print()
        {
            if (denominator == 0)
            {
                Console.WriteLine("Undefined number. Denominator is zero");
            }
            else if(numerator == 0)
            {
                Console.WriteLine(0);
            }
            Console.WriteLine($"{numerator}/{denominator}");
        }
        public void Reduce()
        {
            int hcf = HCF(numerator, denominator);
            if (numerator==0 || denominator == 0)
            {
                Console.WriteLine("The reduction is not possible as either numerator or denominator is zero.");
            }
            while (hcf > 1) // when HCF is 1 (meaning no more CFs, exit loop. hcf returns 0;
            {
                numerator = numerator / hcf;
                denominator = denominator / hcf;
                hcf = HCF(numerator, denominator);
            }

        }
        public Rational Multiply(Rational x)
        {
            Rational final = new Rational(0, 0);
            final.numerator = numerator * x.numerator;
            final.denominator = denominator * x.denominator;
            final.Reduce();
            return final;
        }
        public Rational Divide(Rational x)
        {
            Rational final = new Rational(0, 0);
            final.numerator = numerator * x.denominator;
            final.denominator = denominator * x.numerator;
            final.Reduce();
            return final;
        }
        public Rational Add(Rational x)
        {
            Rational final = new Rational(0, 0);
            final.numerator = numerator*x.denominator + x.numerator*denominator;
            final.denominator = denominator * x.denominator;
            final.Reduce();
            return final;
        }
        public Rational Subtract(Rational x)
        {
            Rational final = new Rational(0, 0);
            final.numerator = numerator * x.denominator - x.numerator * denominator;
            final.denominator = denominator * x.denominator;
            final.Reduce();
            return final;
        }
        static int HCF(int a, int b)
        {
            while (a != b && a > 1 && b > 1)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            if(a <=1 || b <= 1)
            {
                return 0; // returns 0 to exit the HCF loop.
            }
            else return a;
        }
    }

}
