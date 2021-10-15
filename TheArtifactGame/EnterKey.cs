using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace TheArtifactGame
{
    public class EnterKey
    {
        private string[] Options;
        private string Continue;

        public EnterKey(string prompt, string[] options)
        {
            Continue = prompt;
            Options = options;

        }

        public void DisplayContinueOption()
        {
            string continueOption = Options[0];
            string prefix = "*";
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            WriteLine($"{prefix} << {continueOption} >>");
            ResetColor();
        }
        public void Enterkey()
        {
            
            DisplayContinueOption();
            ConsoleKey enterKeyPressed;
            do
            {
            
                ConsoleKeyInfo enterKeyInfo = ReadKey(true);
                enterKeyPressed = enterKeyInfo.Key;
                if (enterKeyPressed == ConsoleKey.Enter)
                {


                }
                else
                {
                    WriteLine("Please Press Enter to Continue");
                    
                }
            } while (enterKeyPressed!=ConsoleKey.Enter);
              
        
        
        }
    }
}
