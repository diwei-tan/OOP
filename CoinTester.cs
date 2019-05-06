using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class CoinTester
    {
        static void Main()
        {
            Coin c1 = new Coin();
            Coin c2 = new Coin();
            Console.WriteLine("C1 is {0}.",c1.GetFace());
            Console.WriteLine("C2 is {0}.",c2.GetFace());
            c1.Flip();
            Console.WriteLine("C1 is {0}.", c1.GetFace());
            Console.WriteLine("C2 is {0}.", c2.GetFace());
            c1.Flip();
            Console.WriteLine("C1 is {0}.", c1.GetFace());
            Console.WriteLine("C2 is {0}.", c2.GetFace());
            c1.Flip();
            c2.Setface(1);
            c1.Setface(3);
            Console.WriteLine("C1 is {0}.", c1.GetFace());
            Console.WriteLine("C2 is {0}.", c2.GetFace());

        }
    }
}
