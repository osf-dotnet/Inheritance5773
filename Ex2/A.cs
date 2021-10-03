using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class A
    {
        private int x;
        private int y;
        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("run A(" + x + "," + y + ")");
        }
        public A(int x)
        {
            this.x = x;
            this.y = x;
            Console.WriteLine("run A(" + x + ")");
        }
        public A()
        {
            Console.WriteLine("run A()");
        }
    }


}
