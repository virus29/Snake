﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1,3,'*');
            Draw();

            point p2 = new point(4,5,'#');
            Draw();

            Console.ReadLine();
        }
    }
}
