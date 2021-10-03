using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            Console.WriteLine("-----------");
            B b2 = new B(2, 4);
            Console.WriteLine("-----------");
            B b3 = new B(3, 5, 7);
        }
    }
}
