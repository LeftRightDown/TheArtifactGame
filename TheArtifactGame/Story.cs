using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace TheArtifactGame
{
    public class Story
    {
        //Instance of Player
        Player Voyager = new Player("Voyager");
        static Player Robot = new Player("Aurora");
        static Player Unkown = new Player("Uknown");
        //Dialog method
        void Dialog(string message, ConsoleColor Color)
        {
            ForegroundColor = Color;

            Write(message);
            ResetColor();
        }


        //Story Telling String Arrays
        public string[] PlotIntro =
        {
         //0
         "It is the Clestial Year 2085 and Humanity has reached for the stars once more. " +
         "Sparking a the new age of Exploration!\n" +
         "You are a hot-shot pilot looking for a way to make tons of money\n"+
         "This is the beginning of your Story...\n",
         //1
         "You Wake up from your nap on your way to meet up with a black market merchant for information.\n" +
         "Upon Awaking your greeted by your Robot companion Aurora who seems to be pointing something at you.\n"+
         "Still a little sleepy you take a closer look only to realize she is pointing her blaster at you.\n"
        };



        public string[] PlotOne =
         {
         //0
         $"You decide to check out the navigation systems\n" +
         $"You exit out of your room making your way down the corridor with its light flickering back and forth.\n"+
         $"As you walk past the light you bang your fist against the wall causing the light to fix itself.\n"+
         $"Entering the bridge you're greeted with specks of light out the window filling up the darkness of space.\n" +
         $"You open up your control panel, acessing the navigational systems.\n"+
         $"The ship is still on its correct course and will reach its destination in two weeks.\n",
         //1
         $"You decide to check on the engine coolant systems.\n" +
         $"You exit out of your room taking a left down the corridor.\n"+
         $"You walk into the engine control room and grab the tablet hanging on the wall.\n"+
         $"With the tablet you note the current temperatures and adjust the fuse valves for optimal performance.",
         //2
         $"Suddenly an alarm siren goes off and the lights switch to emrgency mode.\n" +
         $"You quickly make your way to the control panel to see it is a distress singal coming from a ship at heading 294, mark 35.\n"+
         $"You make your way to the pilot seat and replot your destination towards the the distress signal.",
         //3
         $"As you exit the engine room the alarm system goes off and the lights switch to emergency mode.\n"+
         $"You quickly make your way to the bridge to check out the whats causing the alarm.\n"+
         $"{Robot.PlayerName} looks at you and reveals that there is a distress singal from a ship at heading 294, mark 35.\n"+
         $"You make your way to the pilot seat and replot your destination towards the the distress signal.",
        };




        public string[] PlotTwo =
        {
         //0 Boarding Ship
         $"You decide to board the merchant ship and put on your space suit with the help of Aurora.",
         
         //1 Scanning Ship
         $"You decide to use the ships high tech scanners to look for any life forms on the ship.",




        };

        public string[] PlotThree =
        {
         //0
         $"You Hop into the Airlock preparing to board the ship.\n"+
         $"{Robot.PlayerName} closes airlock and relases the door causing you to get pulled into open space.\n"+
         $"You use your jet propulsion to maneuver your way on to the smoking ship.\n"+
         $"Grabbing onto the ships exterior handlebars you pull the emergency lever on the exterior door and make your way into the ship.\n",





        };


        public string[] PlotFour =
        {
         //0 Left
         $"Walking down the corridor you notice sets of similar doorways on both sides.\n"+
         $"You decide to check out each door way as you walk past them.\n" +
         $"Each one having the same design as one another.\n" +
         $"Nothing of interest in any of the rooms.\n",
         //1 Right
         $"Your gut feeling invites you to take a right so you follow it and walk down the corridor.\n"+
         $"As you walk down the corridor you notice instability of the support structures all around you.\n"+
         $"Then suddenly the ship shakes as a result of an explosion causing your surrounds to collapse in all around you.\n",
         //2 Forwards
         $"You decide to go straight as the two other options seems to uninterest you.\n"+
         $"As you walk down the corridor you seem to notice black stain marks along the left side of the wall.\n"+
         $"Taking a closer look you realize these are laser blast marks.",
         
         //3 Explosion
         $"As you move closer to the end of the corridor the ship begins to shake\n"+
         $"As a result, it puts off balance and you fall to the ground.\n",
        };

        public string[] PlotFive =
        {
         //0 Walk Past
         $"You ignore the body on the ground and keep walking forward towards the bridge.\n" +
         $"You walk up to the door to enter the bridge but the door won't budge with a keycard.\n" +
         $"So you head back to the dead body.\n",
         // 1 Investigate
         $"You move closer to the body and come to the conlusion that this was the merchant.\n" +
         $"Rummaging through his stuff you find a keycard that you assume is useful.\n" +
         $"You start heading towards the bridge and open it with his key card.\n",
        
         //2 Bridge
         $"Entering the bridge you quickly look for anything useful and find the ship schematics.\n" +
         $"Then you head back into the hallway.\n",





        };
        public string[] PlotSix =
        {
          $"",


        };
        public string[] PlotSeven =
        {
          $"",


        };
        public string[] Death =
        {
            @"                

                               .... NO! ...                  ... MNO! ...
                           ..... MNO!! ...................... MNNOO! ...
                         ..... MMNO! ......................... MNNOO!! .
                        .... MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!! .
                         ... !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO! ....
                            ...... ! MMMMMMMMMMMMMPPPPOOOOIII! ! ...
                           ........ MMMMMMMMMMMMPPPPPOOOOOOII!! .....
                           ........ MMMMMOOOOOOPPPPPPPPOOOOMII! ...  
                            ....... MMMMM..    OPPMMP    .,OMI! ....
                             ...... MMMM::   o.,OPMP,.o   ::I!! ...
                                 .... NNM:::.,,OOPM!P,.::::!! ....
                                  .. MMNNNNNOOOOPMO!!IIPPO!!O! .....
                                 ... MMMMMNNNNOO:!!:!!IPPPPOO! ....
                                   .. MMMMMNNOOMMNNIIIPPPOO!! ......
                                  ...... MMMONNMMNNNIIIOO!..........
                               ....... MN MOMMMNNNIIIIIO! OO ..........
                            ......... MNO! IiiiiiiiiiiiI OOOO ...........
                          ...... NNN.MNO! . O!!!!!!!!!O . OONO NO! ........
                           .... MNNNNNO! ...OOOOOOOOOOO .  MMNNON!........
                           ...... MNNNNO! .. PPPPPPPPP .. MMNON!........
                              ...... OO! ................. ON! .......
                                 ................................
            ",

            @"
                                 ▄· ▄▌      ▄• ▄▌    ·▄▄▄▄  ▪  ▄▄▄ .·▄▄▄▄  
                                ▐█▪██▌▪     █▪██▌    ██▪ ██ ██ ▀▄.▀·██▪ ██ 
                                ▐█▌▐█▪ ▄█▀▄ █▌▐█▌    ▐█· ▐█▌▐█·▐▀▀▪▄▐█· ▐█▌
                                 ▐█▀·.▐█▌.▐▌▐█▄█▌    ██. ██ ▐█▌▐█▄▄▌██. ██ 
                                  ▀ •  ▀█▄▀▪ ▀▀▀     ▀▀▀▀▀• ▀▀▀ ▀▀▀ ▀▀▀▀▀• 
             ",
        };


        // Plot Dialog Method Call
        public void PlotDialogPartOne()
        {

            //Character Setup
            WriteLine("(Enter your name)");
            Dialog(
                    "YOU: WOAH WOAH WOAH ITS ME ITS ME: "
                    , ConsoleColor.Blue);
            Voyager.PlayerName = ReadLine();

            Dialog(
                   $"{Robot.PlayerName}: {Voyager.PlayerName}?\n" +
                   $"{Robot.PlayerName}: oh oh I remember you!\n" +
                   $"{Robot.PlayerName}: {Voyager.PlayerName} My HUMAN!\n" +
                   $"{Robot.PlayerName}: I totally didn't forget about you....\n",
                   ConsoleColor.Yellow);
            Thread.Sleep(4500);
            Dialog(
                   $"{Voyager.PlayerName}: We really need to fix your memory drive..\n",
                   ConsoleColor.Blue
                  );
            Thread.Sleep(3000);
            Dialog(
                   $"{Robot.PlayerName}: Anyways! Welcome back {Voyager.PlayerName}!\n" +
                   $"{Robot.PlayerName}: I've been keeping this ship together while you took your nap\n" +
                   $"{Robot.PlayerName}: But I made sure to leave something for you to do!\n" +
                   $"{Robot.PlayerName}: Here is this weeks to-do list\n",
                   ConsoleColor.Yellow
                   );


        }

        //Dialog Method for PlotTwo Option A
        public void PlotDialogPartTwoA()
        {
            Dialog(
                $"{Robot.PlayerName}: Your all set!\n" +
                $"{Robot.PlayerName}: What do you Plan to do?\n",
                ConsoleColor.Yellow
                );
            Dialog(
             $"{Voyager.PlayerName}: Looks like we got free loot.\n" +
             $"{Voyager.PlayerName}: Stay on the ship for me.\n",
             ConsoleColor.Blue
             );

        }
        //Dialog Method for PlotTwo Option B
        public void PlotDialogPartTwoB()
        {
            Dialog(
                $"{Voyager.PlayerName}: {Robot.PlayerName} Scan the ship!\n",
                ConsoleColor.Blue
                );
            Dialog(
                $"{Robot.PlayerName}: Scanning!\n",
                ConsoleColor.Yellow
                );
            Thread.Sleep(1500);
            Dialog(
                $"{Robot.PlayerName}: No lifeforms detected!\n" +
                $"{Robot.PlayerName}: What do you Plan to do?\n",
                ConsoleColor.Yellow
                );
            Thread.Sleep(2000);
            Dialog(
                $"{Voyager.PlayerName}: Looks like we got free loot.\n" +
                $"{Voyager.PlayerName}: Stay on the ship for me.",
                ConsoleColor.Blue
                );
        }

        public void PlotDialogPartFourA()
        {
            Dialog(
                $"{Voyager.PlayerName}: {Robot.PlayerName} Can you hear me? What was that?\n",
                ConsoleColor.Blue
                );
            Dialog(
                $"{Robot.PlayerName}: There seems to have been a secondary explosion from the previous smoking area.\n",
                ConsoleColor.Yellow
                );
            Dialog(
                $"{Voyager.PlayerName}: Previous?\n",
                ConsoleColor.Blue
                );
            Dialog(
                $"{Robot.PlayerName}: It's on fire now.\n",
                ConsoleColor.Yellow
                );

        }

    }
     
}
    
