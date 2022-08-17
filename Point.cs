using System;
namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public Point()
        {
            //Console.WriteLine("Новая точка");
        }

        public Point(int _x, int _y, char _sim)
        {
            x = _x;
            y = _y;
            sim = _sim;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
    }
}

