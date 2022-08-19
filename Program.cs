using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.SetBufferSize(80, 20);

            HorizontalLine upLine = new HorizontalLine(0, 100, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 100, 40, '+');
            VerticallLine leftLine = new VerticallLine(0, 0, 40, '+');
            VerticallLine rightLine = new VerticallLine(100, 0, 40, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p2 = new Point(40, 15, '#');
            Snake snake = new Snake(p2, 5, Direction.UP);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(100, 40, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(500);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HeadleKey(key.Key);
                }
            }


            //Console.ReadLine();
        }

    }
}

