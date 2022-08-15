using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x1 = 1;
            //int y1 = 3;
            //char sim1 = '*';

            //Draw(x1, y1, sim1);

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sim = '*';
            p1.Draw();

            //int x2 = 4;
            //int y2 = 5;
            //char sim2 = '#';

            //Draw(x2, y2, sim2);

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sim = '#';
            p2.Draw();

            Console.ReadLine();
        }

        //static void Draw(int x, int y, char sim)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(sim);
        //}
    }
}

