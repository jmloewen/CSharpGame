using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessinAround
{
    
    public class Mover
    {
        private int width;
        private int height;
        private int curX;
        private int curY;
        private bool isActive = false;
        public Mover()
        {
            Random rand = new Random();
            width = 10;
            height = width;
            isActive = true;
            curX = rand.Next(10, (25 * 30) + 7);
            curY = rand.Next(10, (20 * 21));
        }
        public void setX(int x)
        {
            curX = x;
        }
        public void setY(int y)
        {
            curY = y;
        }

        public int getX()
        {
            return curX;
        }
        public int getY()
        {
            return curY;
        }

        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }
    }
}
