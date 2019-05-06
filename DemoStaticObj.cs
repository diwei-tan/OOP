using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    class DemoStaticObj
    {
        int x;
        static int y;
        public DemoStaticObj(int xx, int yy)
        {
            x = xx;
            y = yy;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int value)
        {
            y = value;
        }
    }
}
