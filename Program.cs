using System;
using System.Collections.Generic;

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

            Point p2 = new Point(40, 5, '#');
            Snake snake = new Snake(p2, 5, Direction.LEFT);
            snake.Draw();

            Console.ReadLine();
        }

    }
}

