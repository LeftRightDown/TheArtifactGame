using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace TheArtifactGame
{
    class Game
    {
        Player Voyager = new Player("Voyager");
        Player Robot = new Player("Aurora");
        Story Plot = new Story();


        //In-game Items
        Item Artifact = new Item();
        Item Tablet = new Item();
        Item KeyCard = new Item();
        Item Schematics = new Item();

        public void Setupitems()
        {
            Artifact.Name = "The Artifact";
            Artifact.Description = "A Relic of a long lost civilization known as the Xurr.\nRumored to hold the long lost secretes to their technological advanceds.";

            Tablet.Name = "Gauge Tablet";
            Tablet.Description = "Touch screen tablet that displays gauge information";

            KeyCard.Name = "Merchant Keycard";
            KeyCard.Description = "Keycard found on dead merchants body\nCould be used to open door to storage room.";

            Schematics.Name = "Merchant Ship Schematics";
            Schematics.Description = "Diagram layout of Merchant ship\nReveals that the storage room is forward.";

        }

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
            Setupitems();
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

            string[] options = { "A) Check Navigation System", "B) Check Coolant System", "C) Inventory" };
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
                case 2:
                    //Check inventory method
                    WriteLine("You Choose to check your Inventory");
                    WriteLine("");
                    Voyager.Displayinventory();
                    Enterkey("Press Enter to go Back", ConsoleColor.Cyan);
            
                    ShowUserPartOne();
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
                      You realize that this is the merchant ship you were going to meet with.
                      You message the distress ship but recive no response. 
                      So you are left with two options: Boarding the ship or Scanning it for life forms.

                        ";

                string[] options = { "A) Board the ship", "B)Scan the ship for lifeforms", "C) Inventory" };
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
                    case 2:
                        WriteLine("You Choose to check your Inventory");
                        WriteLine("");
                        Voyager.Displayinventory();
                        Enterkey("Press Enter to go Back", ConsoleColor.Cyan);

                        ShowUserPartTwo();
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

                string[] options = { "A) Left", "B) Right", "C) Forward", "D) Inventory" };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You Choose to go Left\n");
                        WriteLine(Plot.PlotFour[0]);
                        Thread.Sleep(5000);
                        WriteLine(Plot.PlotFour[4]);
                        WriteLine("");
                        Thread.Sleep(8500);
                        Plot.PlotDialogPartFour();
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                        ShowUserPartFive();
                        break;
                    case 1:
                        WriteLine("You Choose to go Right\n");
                        WriteLine(Plot.PlotFour[1]);
                        Thread.Sleep(10000);
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
                        WriteLine("");
                        WriteLine(Plot.PlotFour[3]);
                        Thread.Sleep(5000);
                        WriteLine("");
                        WriteLine(Plot.PlotFour[4]);
                        WriteLine("");
                        Thread.Sleep(5000);
                        Plot.PlotDialogPartFour();
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                        ShowUserPartFive();
                        break;
                    case 3:
                        WriteLine("You Choose to check your Inventory");
                        WriteLine("");
                        Voyager.Displayinventory();
                        Enterkey("Press Enter to go Back", ConsoleColor.Cyan);

                        ShowUserPartFour();
                        //Check inventory method
                        break;
                }
            }

            void ShowUserPartFive()
            {
                Clear();
                string prompt = @"

                         .                
                       .     '             '      .      .
                                __.--._          > <
                        .     .'   L   `.--._     '
                       > <    `/ c '`    \   `.
                        '     :           ;    `.    `     ,
                              |           ;      \
                             /`.     | ' /        \     .
                        '   / -.\ \  ^ ;/   _      \   > <
                           :    \`.:/ \|     `.|    ;   '
                           |     :''   '       ;    |
                           |     |`.         _/_    ;
                [bug]      :     :  `-._____/   `. /
                            \    |         :/ ,   V\
                  /^\    __.--; _:         `./ /  ; ;
                 :  |\_ /     |  \L _..--.   `.L.'  |`.   __
                 |  | ;`.    ; _ \\'      `.          /`+'.'`.
                 |  | |      | \CT_;        `-.      ' / /   |
                 |-_| |   .- '`.___.         `-.    / /    ;
                 :  ; :.-'                         `-./ /.   /
                  \/_ /_                              \/  `./
                                                       `._.'
                 You pick yourself up but your vision is detered because of the lights switching ot emergency mode.
                 Ignoring the sudden collapse of whatever was behind you, you keep moving in the same direction.
                 Opening the last doorway you notice a body lying on the ground agaisnt the wall
                        ";
                string[] options = { "A) Ignore", "B) Investigate", "C) Inventory" };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You Choose to Ignore.");
                        WriteLine("");
                        if (Voyager.PlayerInventory.Contains(KeyCard))
                        {
                            WriteLine(Plot.PlotFive[2]);
                            Voyager.PlayerInventory.Add(Schematics);
                            Thread.Sleep(2000);
                            Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
                            ShowUserPartSix();
                        }
                        else
                        {
                            WriteLine(Plot.PlotFive[0]);
                            Thread.Sleep(2000);
                            Enterkey("Press Enter to go Back", ConsoleColor.Cyan);
                            ShowUserPartFive();
                        }
                        
                        
                        break;
                    case 1:
                        WriteLine("You Choose to Investigate.");
                        WriteLine("");
                        WriteLine(Plot.PlotFive[1]);
                        Thread.Sleep(5500);
                        Voyager.PlayerInventory.Add(KeyCard);
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
                        ShowUserPartFive();
                        break;
                    case 2:
                        //Check inventory method
                        WriteLine("You Choose to check your Inventory");
                        WriteLine("");
                        Voyager.Displayinventory();
                        Enterkey("Press Enter to go Back", ConsoleColor.Cyan);

                        ShowUserPartFive();
                        break;
                }
            }
            void ShowUserPartSix()
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
                     You reach the four way intersection once again.
                     There are only two options: Left or Forward.
                                ";

                string[] options = { "A) Left", "B) Forward", "C) Inventory" };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You Choose to go Left\n");
                        WriteLine(Plot.PlotSix[0]);
                        WriteLine("");
                        Thread.Sleep(1200);
                        Enterkey("Press Enter to go Back", ConsoleColor.Cyan);
                        ShowUserPartSix();
                        break;
                    case 1:
                        WriteLine("You Choose to go Forward\n");
                        WriteLine(Plot.PlotSix[1]);
                        WriteLine("");
                        Thread.Sleep(10000);
                        WriteLine("");
                        WriteLine(Plot.PlotSix[2]);
                        Voyager.PlayerInventory.Add(Artifact);
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
                        ShowUserPartSeven();
                        break;
                    case 2:
                        //Check inventory method
                        WriteLine("You Choose to check your Inventory");
                        WriteLine("");
                        Voyager.Displayinventory();
                        Enterkey("Press Enter to go Back", ConsoleColor.Cyan);

                        ShowUserPartSix();
                        break;
                }
            }

             void ShowUserPartSeven()
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
                            Which way will lead you to saftey?      
                            ";

                string[] options = { "A) Left", "B) Right", "C) Forward", "D) Inventory " };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You Choose to go Left\n");
                        WriteLine(Plot.PlotSeven[0]);
                        WriteLine("");
                        Thread.Sleep(4000);
                        Clear();
                        WriteLine(Plot.Death[0]);
                        WriteLine(Plot.Death[1]);
                        Enterkey("Press Enter to go decision phase", ConsoleColor.Cyan);
                        ShowUserPartSeven();
                        break;
                    case 1:
                        WriteLine("You Choose to go Right\n");
                        WriteLine(Plot.PlotSeven[1]);
                        WriteLine("");
                        Thread.Sleep(10500);;
                        WriteLine(Plot.PlotSeven[3]);
                        Thread.Sleep(7000);
                        Clear();
                        WriteLine(Plot.Death[0]);
                        WriteLine(Plot.Death[1]);
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);

                        ShowUserPartSeven();
                        break;
                    case 2:
                        WriteLine("You Choose to go Forward\n");
                        WriteLine("");
                        WriteLine(Plot.PlotSeven[2]);
                        Thread.Sleep(1000);
                        Plot.PlotDialogPartSeven();
                        Thread.Sleep(2000);
                        WriteLine(Plot.PlotSeven[4]);
                        Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
                        End();
                        break;
                    case 3:
                        //Check inventory method
                        WriteLine("You Choose to check your Inventory");
                        WriteLine("");
                        Voyager.Displayinventory();
                        Enterkey("Press Enter to go Back", ConsoleColor.Cyan);

                        ShowUserPartSeven();
                        break;

                }
            }
        }
        //Display About Section
        void DisplayAboutInfo()
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
            Clear();
            WriteLine(Plot.PlotEight[0]);
            Thread.Sleep(1000);
            Plot.PlotDialogPartEight();
            Thread.Sleep(1200);
            Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
            Clear();
            WriteLine(@"

                          _
                        _/-\_ 
                     .-`-:-:-`-.
                    /-:-:-:-:-:-\
                    \:-:-:-:-:-:/
                     |`       `|
                     |         |
                jgs  `\       /'
                       `-._.-'

            ");
            WriteLine(Plot.PlotEight[1]);
            WriteLine(Plot.PlotEight[2]);
            Thread.Sleep(5000);
            Clear();
            WriteLine(Plot.End[0]);
            Thread.Sleep(5000);
            Enterkey("Press Enter to Continue", ConsoleColor.Cyan);
            RunMainMenu();




        }
    }

}  
    


