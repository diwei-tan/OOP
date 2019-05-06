using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    class DemoStaticTest
    {
        static void Main()
        {
            DemoStaticObj obj1 = new DemoStaticObj(3, 5);
            Console.WriteLine(obj1.GetX() + " " + obj1.GetY());
            DemoStaticObj obj2 = new DemoStaticObj(7, 9);
            Console.WriteLine(obj2.GetX() + " " + obj2.GetY());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            obj2.SetX(11);
            obj2.SetY(15);
            Console.WriteLine(obj1.GetX() + " " + obj1.GetY());
            Console.WriteLine(obj2.GetX() + " " + obj2.GetY());

        }
    }
}
