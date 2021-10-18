﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace TheArtifactGame
{
    class Game
    {
        List<string> PlayerInventory = new List<string>();
        Player Voyager = new Player("Voyager");
        Player Robot = new Player("Aurora",List<);
        Story Plot = new Story();
        




        //Opens TitleScene
        public void TitleScene()
        {

            string TitleText = @"


                       ████████╗██╗  ██╗███████╗     █████╗ ██████╗ ████████╗██╗███████╗ █████╗  ██████╗████████╗
                       ╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝██╔══██╗██╔════╝╚══██╔══╝
                          ██║   ███████║█████╗      ███████║██████╔╝   ██║   ██║█████╗  ███████║██║        ██║   
                          ██║   ██╔══██║██╔══╝      ██╔══██║██╔══██╗   ██║   ██║██╔══╝  ██╔══██║██║        ██║   
                          ██║   ██║  ██║███████╗    ██║  ██║██║  ██║   ██║   ██║██║     ██║  ██║╚██████╗   ██║   
                          ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝╚═╝     ╚═╝  ╚═╝ ╚═════╝   ╚═╝  
                                                     (Press Enter to Continue)                                                                     
                ";

            WriteLine(TitleText);
            Enterkey("", ConsoleColor.Cyan);
            Clear();
            RunMainMenu();

        }
        //Opens game Main Menu
        private void RunMainMenu()
        {
            //Print out game title and overview

            string prompt = @"


                       ████████╗██╗  ██╗███████╗     █████╗ ██████╗ ████████╗██╗███████╗ █████╗  ██████╗████████╗
                       ╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝██╔══██╗██╔════╝╚══██╔══╝
                          ██║   ███████║█████╗      ███████║██████╔╝   ██║   ██║█████╗  ███████║██║        ██║   
                          ██║   ██╔══██║██╔══╝      ██╔══██║██╔══██╗   ██║   ██║██╔══╝  ██╔══██║██║        ██║   
                          ██║   ██║  ██║███████╗    ██║  ██║██║  ██║   ██║   ██║██║     ██║  ██║╚██████╗   ██║   
                          ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝╚═╝     ╚═╝  ╚═╝ ╚═════╝   ╚═╝  
                                                       Welcome to the Game!
                                               (Use Arrow Keys to navigate Menu Options)
                          ";
            string[] Options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, Options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    PressPlay();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;

            }

        }
        //Starts Actual Game
        private void PressPlay()
        {
            

            Clear();
           string InstructionsText = @"

                ██╗  ██╗ ██████╗ ██╗    ██╗    ████████╗ ██████╗     ██████╗ ██╗      █████╗ ██╗   ██╗    
                ██║  ██║██╔═══██╗██║    ██║    ╚══██╔══╝██╔═══██╗    ██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝    
                ███████║██║   ██║██║ █╗ ██║       ██║   ██║   ██║    ██████╔╝██║     ███████║ ╚████╔╝     
                ██╔══██║██║   ██║██║███╗██║       ██║   ██║   ██║    ██╔═══╝ ██║     ██╔══██║  ╚██╔╝      
                ██║  ██║╚██████╔╝╚███╔███╔╝       ██║   ╚██████╔╝    ██║     ███████╗██║  ██║   ██║       
                ╚═╝  ╚═╝ ╚═════╝  ╚══╝╚══╝        ╚═╝    ╚═════╝     ╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝       
                                                                                               
             ";
            WriteLine(InstructionsText);
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Use ARROW KEYS to navigate the menu and use ENTER to continue story.");
            ResetColor();
            Thread.Sleep(1000);
            Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
            Clear();

            WriteLine(Plot.PlotIntro[0]);
            Thread.Sleep(6500);
            WriteLine(Plot.PlotIntro[1]);
            Thread.Sleep(7000);
            Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


            Plot.PlotDialogPartOne();
            Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
            ShowUserPartOne();



            

        }

        private void ShowUserPartOne()
        {
            Clear();
            string prompt = @"
            .-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-.
            |.-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-.|           
            ||                                                   ||
            ||        TO DO LIST                                 ||
            ||                                                   ||
            ||           A) Check Navigation System              ||
            ||                                                   ||
            !!           B) Check Coolant System                 !!
            ::                                                   ::
            ::                                                   ::
            ..                                                   ..
            ..                                                   ..
 
            ::                                                   ::                                    
            ::                                                   ::
            ::                                                   ::
            ||                                                   ::
            ||                                                   ||
            ||                                                   ||
            ||                                                   || 
            ||                                                   ||
            ||                                                   ||
            ||                                                   ||
            |`-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-='| 
             `-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-'          
            Aurora hands you a tablet from her personal compartment.
            You verify your identiy with a face scan and navigate to the to-do list.
            It seems Aurora has left you two jobs to do: Check Navigation System or Check Coolant System.
                        ";

            string[] options = { "A) Check Navigation System", "B) Check Coolant System" };
            Menu HallwayMenu = new Menu(prompt, options);
            int selectedIndex = HallwayMenu.Run();




            switch (selectedIndex)
            {
                case 0:
                    WriteLine("You Choose to Check Navigation System\n");
                    WriteLine(Plot.PlotOne[0]);
                    Thread.Sleep(20000);
                    WriteLine("");
                    WriteLine(Plot.PlotOne[2]);
                    Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                    ShowUserPartTwo();
                    break;
                case 1:
                    WriteLine("You Choose to Check Coolant System\n");
                    WriteLine(Plot.PlotOne[1]);
                    Thread.Sleep(15000);
                    WriteLine("");
                    WriteLine(Plot.PlotOne[3]);
                    Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                    ShowUserPartTwo();
                    break;
            }


            void ShowUserPartTwo()
            {
                Clear();
                string prompt = @"
                                                                      )
                                                                     (   )
                                                 `. ___          ( . , (
                                                __,' __`.         )( (  )   _..----....____
                                    __...--.'``;.   ,.   ;``--.._(, .)    .'    ,-._    _.-'
                              _..-''-------'   `'   `'   `'     O ``-''._   (,;') _,'
                            ,'________________                          \`-._`-','
                             `._              ```````````------...___   '-.._'-:
                                ```--.._      ,.                     ````--...__\-.
                                        `.--. `-`                       ____    |  |`
                                          `. `.                       ,'`````.  ;  ;`
                                            `._`.        __________   `.      \'__/`
                                               `-:._____/______/___/____`.     \  `
                                                           |       `._    `.    \
                                                           `._________`-.   `.   `.___
                                                                         SSt  `------'`

                      You arrive to the location of the distress signal and see a smoking ship outside the window.
                      You message the distress ship but recive no response. 
                      So you are left with two options: Boarding the ship or Scanning it for life forms.

                        ";

                string[] options = { "A) Board the ship", "B)Scan the ship for lifeforms" };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You Choose to Board ship\n");
                        WriteLine(Plot.PlotTwo[0]);
                        Thread.Sleep(1500);
                        Plot.PlotDialogPartTwoA();
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                        ShowUserPartThree();
                        break;
                    case 1:
                        WriteLine("You Choose to Scan System\n");
                        WriteLine(Plot.PlotTwo[1]);
                        Thread.Sleep(2500);
                        Plot.PlotDialogPartTwoB();
                        WriteLine("");

                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                        ShowUserPartThree();
                        break;
                }

            }
            void ShowUserPartThree()
            {
                Clear();
                string prompt = @"

                
                                     _..._
                                  .'     '.      _
                                 /    .-""-\   _/ \
                               .-|   /:.   |  |   |
                               |  \  |:.   /.-'-./
                               | .-'-;:__.'    =/
                               .'=  *=|NASA _.='
                              /   _.  |    ;
                             ;-.-'|    \   |
                            /   | \    _\  _\
                            \__/'._;.  ==' ==\
                                     \    \   |
                                     /    /   /
                                     /-._/-._/
                              jgs    \   `\  \
                                      `-._/._/
                     ";

                WriteLine(prompt);
                WriteLine(Plot.PlotThree[0]);
                Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                ShowUserPartFour();


            };

            void ShowUserPartFour()
            {
                Clear();
                string prompt = @"
                     _____________________________________________
                    |.'',                                     ,''.|
                    |.'.'',                                 ,''.'.|
                    |.'.'.'',                             ,''.'.'.|
                    |.'.'.'.'',                         ,''.'.'.'.|
                    |.'.'.'.'.|                         |.'.'.'.'.|
                    |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
                    |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
                    |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                    |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
                    |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                    |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
                    |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
                    |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
                    |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
                    |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
                    |.'.','         /%%%%%%%%%%%%%\         ','.'.|
                    |.','          /%%%%%%%%%%%%%%%\          ','.|
                    |;____________/%%%%%Spicer%%%%%%\____________;|
                After closing the door you notice the power still works
                So you decompress in the airlock and take off your helmet.                    
                Upon arrival you are greeted with a four way interesection.
                Each pathway looking rather similar.
                                        ";

                string[] options = { "A)Left", "B)Right ","C)Forward "};
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You Choose to go Left\n");
                        WriteLine(Plot.PlotFour[0]);
                        Thread.Sleep(5000);
                        WriteLine(Plot.PlotFour[3]);
                        WriteLine("");
                        Thread.Sleep(8500);
                        Plot.PlotDialogPartFourA();
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                        ShowUserPartFive();
                        break;
                    case 1:
                        WriteLine("You Choose to go Right\n");
                        WriteLine(Plot.PlotFour[1]);
                        Thread.Sleep(12000);
                        Clear();
                        WriteLine(Plot.Death[0]);
                        WriteLine(Plot.Death[1]);
                        WriteLine("");
                        Enterkey("Press Enter to Continue to decision phase", ConsoleColor.Cyan);

                       ShowUserPartFour();
                        break;
                    case 2:
                        WriteLine("You Choose to go Forward\n");
                        WriteLine(Plot.PlotFour[2]);
                        Thread.Sleep(9000);
                        Plot.PlotDialogPartFourB();
                        WriteLine(Plot.PlotFour[3]);
                        WriteLine("");
                        Thread.Sleep(95000);
                        Plot.PlotDialogPartFourA();
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
                        ShowUserPartFive();
                        break;
                }
            }

            void ShowUserPartFive()
            {
                Clear();
                string prompt = @"
                                       







            
                 As a result of the explosion, the light switch to emergency power saving mode.
                 Ignoring the sudden collapse of whatever was behind you, you keep moving in the same direction.
                 Opening the last doorway infront you notice a mysterious humanoid silhouette standing a couple meters ahead of you. 
                 They don't seem to notice your enterance. What do you do?
                 
                                ";

                string[] options = { "A) Call out to them", "B) Observe them" };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You Choose to Call out to them\n");
                        WriteLine(Plot.PlotFive[0]);
                        Thread.Sleep(5000);
                        Plot.PlotDialogPartFiveA();
                        Thread.Sleep(6000);
                        WriteLine(Plot.PlotFive[1]);
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


                        break;
                    case 1:
                        WriteLine("You Choose to Observe them\n");
                        WriteLine(Plot.PlotFive[3]);
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


                        break;
                }
            }
            void ShowUserPartSix()
            {
                Clear();
                string prompt = @"
                                                     
                                        ";

                string[] options = { "A) ", "B) " };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("\n");
                        WriteLine(Plot.PlotSix[0]);
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


                        break;
                    case 1:
                        WriteLine("\n");
                        WriteLine(Plot.PlotSix[1]);
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


                        break;
                }
            }

            void ShowUserPartSeven()
            {
                Clear();
                string prompt = @"
                                                     
                                        ";

                string[] options = { "A) ", "B) " };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("\n");
                        WriteLine(Plot.PlotThree);
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


                        break;
                    case 1:
                        WriteLine("\n");
                        WriteLine(Plot.PlotThree);
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


                        break;
                }
            }

            void ShowUserPartEight()
            {
                Clear();
                string prompt = @"
                                                     
                                        ";

                string[] options = { "A) ", "B) " };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("\n");
                        WriteLine(Plot.PlotThree);
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


                        break;
                    case 1:
                        WriteLine("\n");
                        WriteLine(Plot.PlotThree);
                        WriteLine("");
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);


                        break;
                }
            }

































        }

        //Display About Section
        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("Created by Zachary Tan");
            WriteLine("Title Assets used from https://patorjk.com/software/taag");
            WriteLine("Menu Code used from https://www.youtube.com/watch?v=qAWhGEPMlS8");
            WriteLine("Art Assets used from https://www.asciiart.eu/");
            WriteLine("");
            WriteLine("Press any key to return to main menu.");
            ReadKey(true);
            RunMainMenu();


        }
        //Exit Game when Chosen
        private void ExitGame()
        {

            WriteLine("\nPress Any Key to Exit");
            ReadKey(true);
            Environment.Exit(0);

        }


        public void Enterkey(string Message, ConsoleColor Color)
        {
            ConsoleKey enterKeyPressed;
            do
            {
                ForegroundColor = Color;
                WriteLine(Message);
 
                ConsoleKeyInfo enterKeyInfo = ReadKey(true);
                enterKeyPressed = enterKeyInfo.Key;
                if (enterKeyPressed == ConsoleKey.Enter)
                {

                }
                else
                {
                    WriteLine("You did not press correct Input");
                    

                }
            } while (enterKeyPressed != ConsoleKey.Enter);
            ResetColor();
           
        }





        void End()
        {
            if (Voyager.PlayerInventory.Contains("The Artifact"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("CONGRAGULATIONS!, You have completed the Game and found the Artifact!");
                Console.ResetColor();

            }





        }
    }
}

