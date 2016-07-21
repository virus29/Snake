using System;
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
            point p1 = new point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw();

            point p2 = new point();
            p1.x = 4;
            p1.y = 5;
            p1.sym = '#';
            Draw();
                       

            Console.ReadLine();
        }
    }
}
