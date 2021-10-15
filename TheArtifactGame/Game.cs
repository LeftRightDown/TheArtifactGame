using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TheArtifactGame
{
    class Game
    {
        List<string> PlayerInventory = new List<string>();
        Player Voyager = new Player("Voyager", ConsoleColor.Blue);
        Player Robot = new Player("Aurora", ConsoleColor.DarkYellow);
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

                                               (Press Enter to Contuine)                                         
                ";

            WriteLine(TitleText);
            ReadKey();
            Clear();
            Title = "The Artifact by: Zachary Tan";
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
            Story Plots = new Story();

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
            ReadKey();
            Clear();

            WriteLine(Plots.PlotIntro[0]);


            
            ReadKey();
            



            void Dialog(string message)
            {
                ForegroundColor = ConsoleColor.DarkCyan;
                Robot.ForegroundColor = ConsoleColor.Yellow;
                Write(message);
                ResetColor();
            }

            //Character Setup
            WriteLine("(Enter your name)");
            Dialog("YOU: WOAH WOAH WOAH ITS ME ITS ME: ");
            Voyager.PlayerName = Console.ReadLine();

            Dialog($"{Robot.PlayerName}: {Voyager.PlayerName}?\noh oh I remember you!\n{Voyager.PlayerName} My HUMAN!");
            Dialog($"{Robot.PlayerName}: Welcome back {Voyager.PlayerName}!\nHere is this weeks to-do list\n");
            ReadKey();
            Clear();
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
                        ";

            string[] options = { "A) Check Navigation System", "B) Check Coolant System" };
            Menu HallwayMenu = new Menu(prompt, options);
            int selectedIndex = HallwayMenu.Run();
            EnterKey pressEnter = new EnterKey();
            
            

            switch (selectedIndex)
            {
                case 0:
                    WriteLine("You Choose to Check Navigation System\n");
                    WriteLine(Plot.PlotOne[0]);
                    
                    
                    ShowUserPartTwo();
                    break;
                case 1:
                    WriteLine("You Choose to Check Coolant System\n");
                    WriteLine(Plot.PlotOne[1]);
                    WriteLine("Press ENTER to Continue");
                    
                    ReadKey();
                    ShowUserPartTwo();
                    break;
            }


            
            void ShowUserPartTwo()
            {
                Clear();
                string prompt = @"
              
                        ";

                string[] options = { "A) Message distress ship", "B)Scan distress ship" };
                Menu ControlRoom = new Menu(prompt, options);
                int selectedIndex = ControlRoom.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("You Choose to Message distress ship\n");
                        WriteLine();
                        WriteLine("Press ENTER to Continue");
                        

                        ShowUserPartTwo();
                        break;
                    case 1:
                        WriteLine("You Choose to Check Coolant System\n");
                        WriteLine();
                        WriteLine("Press ENTER to Continue");

                        ReadKey();
                        ShowUserPartTwo();
                        break;
                }


            }




        }

        //Display About Section
        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("Created by Zachary Tan");
            WriteLine("Title Assets Used from https://patorjk.com/software/taag");
            WriteLine("Menu Code used from https://www.youtube.com/watch?v=qAWhGEPMlS8");
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

