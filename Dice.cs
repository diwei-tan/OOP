using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPday1
{
    class Dice
    {
        int sides = 6;
        int faceUp;
        Random rnd = new Random();
        public void Roll()
        {
            faceUp = rnd.Next(sides);
        }
        public int GetFace()
        {
            return faceUp;
        }
        public void SetFace(int x)
        {
            if (x > 0 && x <= 6)
            {
                faceUp = x;
            }
            else
                Console.WriteLine("the input {0} is an invalid value.", x);
        }
        public Dice()
        {
            sides = 6;
            faceUp = 1;
        }
        public Dice(int x)
        {
            sides = x;
            faceUp = 1;
        }
        public Dice(int x, int y)
        {
            sides = x;
            faceUp = y;
        }
    }
}
