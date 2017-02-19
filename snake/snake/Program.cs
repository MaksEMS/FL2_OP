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
          //  p1.Draw();

            Point p2 = new Point(6, 6, '#');
           // p2.Draw();

            Point p3 = new Point(8, 8, '$');
           // p3.Draw();

            Point p4 = new Point(10, 10, '&');
           // p4.Draw();

            Console.WriteLine();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            numList.RemoveAt(0);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }


            List<char> myNameList = new List<char>();
            myNameList.Add('M');
            myNameList.Add('A');
            myNameList.Add('K');
            myNameList.Add('S');

            foreach (char i in myNameList)
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point i in pList)
            {
                i.Draw();
            }

            Console.ReadLine();
        }
    
    }
}
