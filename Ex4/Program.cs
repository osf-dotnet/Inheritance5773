﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{
    class grandfather
    {
        public string hello()
        {
            return "i am grandfather";
        }
    }

    class father : grandfather
    {
        public string hello()
        {
            return "i am father";
        }
    }
    class son : father
    {
        public string hello()
        {
            return "i am son";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            son s = new son();
            Console.WriteLine(s.hello());
            //////////////////////////////////
            grandfather g = new son();
            Console.WriteLine(g.hello());

        }
    }
}
