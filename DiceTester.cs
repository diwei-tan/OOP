using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class DiceTester
    {
        static void Main()
        {
            Dice d = new Dice();
            Console.WriteLine(d.GetFace());
            d.Roll();
            Console.WriteLine(d.GetFace());
            d.Roll();
            Console.WriteLine(d.GetFace());
            d.Roll();
            Console.WriteLine(d.GetFace());
            d.SetFace(6);
            Console.WriteLine(d.GetFace());
            d.SetFace(123);
            Console.WriteLine(d.GetFace());
        }
    }
}
