using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            // main program for PassValRef here
            int a = 5;
            Console.WriteLine("In Main, before call to M1");
            Console.WriteLine("The value of a is: {0}", a);
            M1(ref a);
            Console.WriteLine("After call, the value of a is: {0}", a);
        }
        static void M1(ref int x)
        {
            Console.WriteLine("In M1");
            Console.WriteLine("The value of x before change is: {0}", x);
            Console.WriteLine("The value of x after change is: {0}", x);
            x = 7;
            Console.WriteLine("The value of x after change is: {0}", x);
            Console.WriteLine("M1 ends");
        }
    }
}
