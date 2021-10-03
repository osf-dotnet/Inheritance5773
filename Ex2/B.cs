using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class B : A
    {
        private int t;
        public B(int x, int y, int z) : base(x, y)
        {
            t = z;
            Console.WriteLine("run B(" + x + "," + y + "," + z + ")");
        }
        public B(int x, int z)
            : base(x)
        {
            t = z;
            Console.WriteLine("run B(" + x + "," + z + ")");
        }
        public B()
        {
            Console.WriteLine("run B()");
        }
    }


}
