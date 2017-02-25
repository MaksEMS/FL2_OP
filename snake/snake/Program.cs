using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Отрисовка точек
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if(walls.IsHit (snake)||snake.IsHitTail())
                {
                    break;
                }

                if(snake.Eat (food))
                {
                    
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
               if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(33, 11);
            Console.WriteLine("GAME OVER");
            Console.SetCursorPosition(33, 12);
            Console.WriteLine("Thanks for Watching");
            Console.SetCursorPosition(33, 13);
            Console.WriteLine("Maks EMS production with GeekBrains");
            Console.SetCursorPosition(33, 14);
            Console.WriteLine("Press Enter for exit");
            Console.ReadLine();
        }
    
    }
}
