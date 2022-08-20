using System;
using System.Collections.Generic;

namespace Snake
{
    class VerticallLine : Figure
    {
        public VerticallLine(int x, int yTop, int yBottom, char sim)
        {
            pList = new List<Point>();
            for(int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
    }
}

