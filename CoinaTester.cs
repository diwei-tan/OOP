using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class CoinaTester
    {
        public static void Main()
        {
            Coina c1 = new Coina(1);
            Console.WriteLine("c1 is {0}", c1.GetFace());
        }
    }
}
