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
                                                    By:Zachary Tan
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

            WriteLine(Plots.PlotIntro[0]);


            
            ReadKey();
            



            void Dialog(string message)
            {
                ForegroundColor = ConsoleColor.Cyan;
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


            switch (selectedIndex)
            {
                case 0:
                    WriteLine("You Choose to Check Navigation System\n");
                    WriteLine(Plot.PlotOne[0]);
                    break;
                case 1:
                    WriteLine("You Choose to Check Coolant System\n");
                    WriteLine(Plot.PlotOne[1]);
                    break;
            }


            //Provide Game Options for PlotOne
            void Option()
            {
                Clear();




            }




        }

        //Display About Section
        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("Created by Zachary Tan");
            WriteLine("Assets Used from https://patorjk.com/software/taag");
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

