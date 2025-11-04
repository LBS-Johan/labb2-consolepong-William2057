using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    class Ball
    {
        int x;
        int y;
        int xVelocity;
        int yVelocity;

        public Ball(int x, int y, int xVelocity, int yVelocity)
        {  
            this.x = x;
            this.y = y;
            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;
        }
        public void Move()
        {  // fråga hur man får spelet att avslutas rätt när bollen går utanför kanterna.
            x += xVelocity;
            y += yVelocity;
            
        }
        public void Draw()
        {
            if (y <= 0 || y >= Console.WindowHeight - 1)
            {
                yVelocity *= -1;
            }
            if (x <= 0 || x >= Console.WindowWidth - 1)
            {
                x = Console.WindowWidth / 2;
                y = Console.WindowHeight / 2;
                
                
                
            }
            Console.SetCursorPosition(x, y);
            Console.Write("o");
        }

        public void CheckCollisions(Paddle leftPlayer, Paddle rightPlayer, int width, int height)
        {
            if (x == leftPlayer.x +1 && (y == leftPlayer.y || y == leftPlayer.y + 1 || y == leftPlayer.y + 2))
            {
                xVelocity *= -1;
            }
            if (x == rightPlayer.x -1 && (y == rightPlayer.y || y == rightPlayer.y + 1 || y == rightPlayer.y + 2 ))
            {
                xVelocity *= -1;
            }
        }

    }
}
