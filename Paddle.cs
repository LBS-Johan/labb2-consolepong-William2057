﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    class Paddle
    {
        int x;
        int y;
        int size;

        public Paddle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }
       public void Move(int yAmount)
        {
            int newY = y - yAmount;
            y = newY;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("|");
        }
    }
}
