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
        {
            x += xVelocity;
            y += yVelocity;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("o");
        }
        void CheckCollisions(Paddle leftPlayer, Paddle rightPlayer, int width, int height)
        {

        }

    }
}
