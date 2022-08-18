using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line1 = new HorizontalLine(5, 40, 15, '+');
            line1.Draw();

            VerticallLine line2 = new VerticallLine(18, 4, 11, '@');
            line2.Draw();

            Console.ReadLine();
        }

    }
}

