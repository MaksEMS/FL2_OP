using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4,4,'*');
            p1.Draw();

            Point p2 = new Point(6, 6, '#');
            p2.Draw();

            HorizontalLine lineH = new HorizontalLine(5,10,8,'+');
            lineH.DrowH();

            VerticalLine lineV = new VerticalLine(2, 7, 7, '$');
            lineV.DrowV();

            Console.ReadLine();
        }
    
    }
}
