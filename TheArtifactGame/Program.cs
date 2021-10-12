/*
 * 
 * [The Artifact]
 * by Zachary Tan, 10/12/2021
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */
using System;
using static System.Console;

namespace TheArtifactGame
{
    class Program
    {
        static void Main()
        {
            WindowHeight = 35;
            WindowWidth = 130;

            Game myGame = new Game();
            myGame.TitleScene();
          

        }
    }
}
