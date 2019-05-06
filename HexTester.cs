using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class HexTester
    {
        static void Main()
        {
            Hex x = new Hex("C5");
            x.AddHex("A4");
            Console.WriteLine("Hexadecimal stored is: " + x.GetNum());
            Console.WriteLine("Decimal no. of the hexadecimal stored is: {0}", x.ToDecimal());
            Console.WriteLine("Binary of the hexadecimal stored is: " + x.ToBinary());
        }
    }
}
