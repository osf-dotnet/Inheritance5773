using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex92
{
    class A
    {
        private int x;
        private int y;

        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //public  string ToString()
        //{
        //    return "x = " + x + " y= " + y;
        //}

        //public string ToString()
        //{
        //    return "x = " + x + " y= " + y;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            

           
            int x = 8;
            string str = "oshri";
            A a = new A(2, 4);
            Console.WriteLine(a);     
        }
    }
}




