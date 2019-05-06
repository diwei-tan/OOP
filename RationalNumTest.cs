using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class RationalNumTest
    {
        static void Main()
        {
            Rational num1 = new Rational(13, 26);
            Rational num2 = new Rational(34, 406);
            num1.Reduce();
            num1.Print();
            num2.Reduce();
            num2.Print();
            Rational product;
            product = num1.Multiply(num2);
            product.Print();
            product = num1.Divide(num2);
            product.Print();
            product = num1.Add(num2);
            product.Print();
            product = num1.Subtract(num2);
            product.Print();

        }
    }
}
