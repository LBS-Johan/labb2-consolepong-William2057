using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;
        Paddle LeftPlayer = new Paddle(0, Console.WindowHeight/2, 3);
        Paddle rightPlayer = new Paddle(Console.WindowWidth -1, Console.WindowHeight/2, 3);
        Ball gameBall = new Ball(Console.WindowWidth/2, Console.WindowHeight/2, 1, 1);

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;
        }
        public bool Run()
        {
            Console.Clear();
            //Töm hela skärmen i början av varje uppdatering.
            
            rightPlayer.Draw();
            LeftPlayer.Draw();
            gameBall.Move();
            gameBall.Draw();
            gameBall.CheckCollisions(LeftPlayer, rightPlayer, width, height);
            
            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                rightPlayer.Move(1, height);
                //Flytta spelare 1 uppåt
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                rightPlayer.Move(-1, height);
                //Flytta spelare 1 nedåt
            }
            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                LeftPlayer.Move(1, height);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                LeftPlayer.Move(-1, height);
            }

            //Return true om spelet ska fortsätta
            return true;
        }
    }
}
