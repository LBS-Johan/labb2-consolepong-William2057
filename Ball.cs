using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    class Ball
    {
        public int x;
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
        {  
            x += xVelocity;
            y += yVelocity;
        }
        public void Draw()
        {
            //Om bollen träffar tak eller golv ska riktningen vända
            if (y <= 0 || y >= Console.WindowHeight - 1)
            {
                yVelocity *= -1;
            }
            //placera bollen i centrum när den har åkt utanför
            if (x <= 0 || x >= Console.WindowWidth - 1)
            {
                x = Console.WindowWidth / 2;
                y = Console.WindowHeight / 2;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("o");
        }
        //Kolla om bollen träffar någon av spelarnas x och y-koordinater
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
