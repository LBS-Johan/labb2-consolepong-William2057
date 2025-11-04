using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    class Paddle
    {
        public int x;
        public int y;
        public int size;
        public Paddle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }
       public void Move(int yAmount, int height)
        {
            int newY = y - yAmount;
            if (newY < 0)
                newY = 0;
            if (newY + size > height)
                newY = height - size;
            y = newY;
        }
        public void Draw()
        {
            for (int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|");
            }
        }
    }
}
