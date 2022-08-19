using System;
using System.Collections.Generic;

namespace Snake
{
    class FoodCreator
    {
        int mapWight;
        int mapHeight;
        char sim;

        Random random = new Random();

        public FoodCreator(int mapWight, int mapHeight, char sim)
        {
            this.mapWight = mapWight;
            this.mapHeight = mapHeight;
            this.sim = sim;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWight - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sim);
        }
    }
}

