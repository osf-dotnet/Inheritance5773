﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
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
            grandfather[] arr = new grandfather[3];
            arr[0] = new grandfather();
            arr[1] = new father();
            arr[2] = new son();

            for (int i = 0; i < 3; i++)
                Console.WriteLine(arr[i].hello());

        }
    }
}
