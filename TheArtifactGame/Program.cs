/*
 * 
 * [The Artifact]
 * by Zachary Tan, 10/12/2021
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 *  Menu Code used from https://www.youtube.com/watch?v=qAWhGEPMlS8
 *  Art Assets used from https://www.asciiart.eu/
 *  Title Assets used from https://patorjk.com/software/taag
 *  Enter Code Refactored by Mack, Pearson-Muggli
 */
using System;
using static System.Console;

namespace TheArtifactGame
{
    class Program
    {
        static void Main()
        {
            WindowHeight = 40;
            WindowWidth = 130;
            Title = "The Artifact";
            Game myGame = new Game();
            myGame.TitleScene();
          

        }
    }
}
