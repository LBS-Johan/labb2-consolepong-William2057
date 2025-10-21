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
        Paddle LeftPlayer = new Paddle(5, 10, 3);
        Paddle rightPlayer = new Paddle(115, 10, 3);
        Ball gameBall = new Ball(20, 10, 1, 1);
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
            
            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                rightPlayer.Move(1);
                //Flytta spelare 1 uppåt
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                rightPlayer.Move(-1);
                //Flytta spelare 1 nedåt
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                LeftPlayer.Move(1);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                LeftPlayer.Move(-1);
            }


            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
