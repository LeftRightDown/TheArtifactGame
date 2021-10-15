using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TheArtifactGame
{
    public class Story
    {

        Player Voyager = new Player("Voyager");
        Player Robot = new Player("Aurora");
        void Dialog(string message, ConsoleColor Color)
        {
            ForegroundColor = Color;

            Write(message);
            ResetColor();
        }

        public string[] PlotIntro =
        {
         "It is the Clestial Year 2085 and Humanity has reached for the stars once more. Sparking a the new age of Exploration!\n"+
         "This is the Beginning of your Story...\n"+
         "You Wake up from Cryostatis almost finished on your 2 month journey to Jupiter.\n"+
         "Upon Awaking your greeted by your Robot companion Aurora who seems to be pointing something at you.\n"+
         "You take a closer look to double check and notice she is pointing her blaster at you."
        };



        public string[] PlotOne =
         {
         $"You decide to check out the navigation systems\nYou exit out of your room making your way down the corridor with its light flickering back and forth.\n"+
         $"As you walk past the light you bang your fist against the wall causing the light to fix itself.\n"+
         $"Entering the bridge you're greeted with specks of light out the window filling up the darkness of space.\nYou open up your control panel, acessing the navagational systems.\n"+
         $"The ship is still on its correct course and will reach its destination in two weeks\n",

         $"You decide to check on the engine coolant systems\nYou exit out of your room taking a left down the corridor"+
         $"You walk into the engine control room and grab the tablet hanging on the wall\n"+
         $"With the tablet you note the current temperatures and adjust the fuse valves for optimal performance",

         $"Suddenly an alarm siren goes off.\nYou quickly make your way to the control panel to see it is a distress singal coming from a ship at heading 294, mark 35\n"+
         $"You make your way to the pilot seat and replot your destination towards the the distress signal.",
    
         $"As you exit the engine room the alarm system goes off and the lights switch to emergency mode\n"+
         $"You quickly make your way to the bridge to check out the whats causing the alarm.\n"+
         $"Aroura looks at you as reveals that the cause of the alarm is a distress singal from another ship at heading 294, mark 35\n"+
         $"You make your way to the pilot seat and replot your destination towards the the distress signal.",
        };

        


        public string[] PlotTwo =
        {
         $"You decide to board the burning ship and put on your space suit to jump onto the ship"+
         $""+
         $""+
         $""+
         $"",



         $""+
         $""+
         $""+ 
         $""+
         $"",



        };

        public string[] PlotThree =
        {





        };


        public string[] PlotFour =
        {



        };
    
       


 
        public void PlotDialogPartOne()
        {
            
            //Character Setup
            WriteLine("(Enter your name)");
            Dialog("YOU: WOAH WOAH WOAH ITS ME ITS ME: ", ConsoleColor.DarkCyan);
            Voyager.PlayerName = ReadLine();

            Dialog($"{Robot.PlayerName}: {Voyager.PlayerName}?\n{Robot.PlayerName}: oh oh I remember you!\n{Robot.PlayerName}: {Voyager.PlayerName} My HUMAN!\n", ConsoleColor.DarkYellow);
            Dialog($"{Robot.PlayerName}: Welcome back {Voyager.PlayerName}!\n{Robot.PlayerName}: Here is this weeks to-do list\n", ConsoleColor.DarkYellow);
           


        }


    }
}
