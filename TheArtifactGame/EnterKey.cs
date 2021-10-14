using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace TheArtifactGame
{
    public class EnterKey
    {

        public string Enterkey()
        {
            ConsoleKey enterKeyPressed;
            do
            {
                Clear();
                WriteLine("Press ENTER to CONTINUE");

                ConsoleKeyInfo enterKeyInfo = ReadKey(true);
                enterKeyPressed = enterKeyInfo.Key;
                if (enterKeyPressed == ConsoleKey.Enter)
                {

                   

                }
                else
                {
                    WriteLine("You did not press correcet Input");
                    Thread.Sleep(3000);
                    return Enterkey();
                }
            } while (true);
        
        
        }
    }
}
