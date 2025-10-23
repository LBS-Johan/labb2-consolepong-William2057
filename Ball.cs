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
        {  //Fråga Johan om vilken position bollen ska vara på skärmen
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
                Console.Clear();
                Console.WriteLine("Game Over!");
                Environment.Exit(0);
            }
            Console.SetCursorPosition(x, y);
            Console.Write("o");
        }

        public void CheckCollisions(Paddle leftPlayer, Paddle rightPlayer, int width, int height)
        {
            if (x == leftPlayer.x && y == leftPlayer.y)
            {
                xVelocity *= -1;
            }
            if (x ==rightPlayer.x && y == rightPlayer.y)
            {
                xVelocity *= -1;
            }
           
        }

    }
}
