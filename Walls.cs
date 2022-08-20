using System;
using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWigth, int mapHeigth)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWigth -2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWigth -2, mapHeigth - 1, '+');
            VerticallLine leftLine = new VerticallLine(0, 0, mapHeigth - 1, '+');
            VerticallLine rightLine = new VerticallLine(mapWigth - 2, 0, mapHeigth - 1, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}