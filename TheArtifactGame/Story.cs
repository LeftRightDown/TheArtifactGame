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
         $"Taking a closer look you realize these are laser blast marks.\n",
         
         //3 Forwards end
         $"Reaching the end of the corridor you encounter big blast doors resembling a storage room.\n" +
         $"However you are unable to open it as it requires a keycard.\n" +
         $"So you head back to the intersection as take a left.",

         
         //4 Explosion
         $"Suddently the ship begins to shake putting you off balance and falling to the ground.",
         
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
          //0 Left
          $"You head back to the direction of the bridge.\n" +
          $"However as soon as you reach the dead merchant you realise its pointles.\n" +
          $"So you head back to the intersection.",
          //1 Forward
          $"Walking forwards you reach the storage room and scan a key card.\n"+
          $"The doors slide wide open and you are greeted with an immense amount of loot filling the entire room.\n" +
          $"Out of all the riches, one item seems to catch your eye.\n" +
          $"An golden egg shaped object with an elaborate decoration\n" +
          $"Picking up the object a screen appears infront of it displaying a varitey of information.\n" +
          $"You read that it is known as The Artifact, believed to be a relic of the lost civilization known as the Xurr.\n",
         
          //2 Escape
          $"Suddenly the ship begins to shake again and notice that fire is beginning to spread further in.\n" +
          $"You quickly throw The Artifact into your pouch and dash out of the room before it is encaged in fire.\n",
          


        };
        public string[] PlotSeven =
        {
          //0 Left
          $"You take a left but run into the collapse corridor.\n" +
          $"As soon you turn around you are engulfed in flames.",

          //1 Right
          $"Making a right you run past the dead body reaching the birdge.\n" +
          $"Realising that there is no escape option around you, you decide check the ships controls.\n" +
          $"Sitting in pilot seat you notice a that the ship has a built in fire safety system.\n" +
          $"You push a random button and foam begins to release all throughout the ship stoping the fire.\n",

          //2 Forward
          $"Putting on your helmet you hastily make your towards the airlock.",

          // 3 Right End
          $"All of the sudden system alarm goes off and an explosion in the main reactor occurs.",

          //4  Forward End
          $"You push the emegency open button and the door slides wide open.\n" +
          $"As it opens you get sucked into open space as the explosion behind you propells you onto your ship.\n" +
          $"{Robot.PlayerName} lets you onto the ship through the exterior door.",
        };
        public string[] PlotEight =
        {
            //0 Enter the Ship
            $"You enter the ship and are greeted by {Robot.PlayerName}.\n",
            //1 Take out Artifact
            $"You take out The Artifact out of your pouch and show it to {Robot.PlayerName}.\n",

            //2 End
            $"Both of you obeserve the egg and then suddenly there is an explosion."




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

        public string[] End =
        {
            //Ending
            @"
                 ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ 
                ██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗
                ██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝
                ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗
                ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║
                 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝

                    Congratulations you have finished the game! Thanks for Playing!
                
            "


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

        public void PlotDialogPartFour()
        {
            Dialog(
                $"{Voyager.PlayerName}: {Robot.PlayerName} Can you hear me? What was that?\n",
                ConsoleColor.Blue
                );
            Thread.Sleep(1200);
            Dialog(
                $"{Robot.PlayerName}: There seems to have been a secondary explosion from the previous smoking area.\n",
                ConsoleColor.Yellow
                );
            Thread.Sleep(1400);
            Dialog(
                $"{Voyager.PlayerName}: Previous?\n",
                ConsoleColor.Blue
                );
            Thread.Sleep(100);
            Dialog(
                $"{Robot.PlayerName}: It's on fire now.\n",
                ConsoleColor.Yellow
                );

        }

        public void PlotDialogPartSeven()
        {

            Dialog(
                $"{Voyager.PlayerName}: {Robot.PlayerName} I'm making a quick exit.\n",
                ConsoleColor.Blue
                );
            Thread.Sleep(1000);
            Dialog(
                $"{Voyager.PlayerName}: Whats the situation outside?\n",
                ConsoleColor.Blue
                );
            Thread.Sleep(1000);
            Dialog(
                $"{Robot.PlayerName}: Scanners indicate explosion in main reactor in approximatly 2 minutes.\n",
                ConsoleColor.Yellow
                );
            Thread.Sleep(2000);
            Dialog(
               $"{Robot.PlayerName}: According to my calculations you do not have enough time to escape.\n",
               ConsoleColor.Yellow
               );
            Thread.Sleep(2000);
            Dialog(
                $"{Voyager.PlayerName}:We'll see about that!\n",
                ConsoleColor.Blue
                );
            Thread.Sleep(1000);
            Dialog(
                $"{Robot.PlayerName}: 60 Seconds!\n",
                ConsoleColor.Yellow
                );



        }

        public void PlotDialogPartEight()
        {

            Dialog(
                $"{Robot.PlayerName}: What did you find?\n",
                ConsoleColor.Yellow
                );
            Thread.Sleep(1000);
            Dialog(
               $"{Voyager.PlayerName}: Our Ticket it paradise.\n",
               ConsoleColor.Yellow
               );
  
        }

    }
     
}
    
