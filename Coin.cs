using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class Coin
    {
        int face;
        Random rnd = new Random();

        public int GetFace() //Accessor
        {
            return face;
        }
        public void Flip()
        {
            face = rnd.Next(2);
        }
        public void Setface(int x) //Mutator
        {
            if (x == 1 || x == 0)
                face = x;
            else
                Console.WriteLine(x + " is not an accepted value");
            //Exception handler? protect object private values
            //usually build protectors with setters.
        }

    }
}
