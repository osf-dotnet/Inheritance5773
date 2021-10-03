using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex91
{
    class grandfather
    {
        public virtual string hello()
        {
            return "i am grandfather";
        }
    }

    class father : grandfather
    {
        public override string hello()
        {
            return "i am father";
        }
    }
    class son : father
    {
        public override string hello()
        {
            return "i am son";
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {                   
            grandfather g = new father();
            father f =  g as father;
            son s =   g as son;
        }
    }
}
