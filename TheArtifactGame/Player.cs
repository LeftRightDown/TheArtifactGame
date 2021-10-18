using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TheArtifactGame
{
    public class Player
    {
        //Property of Players
        public string PlayerName { get; set; }
        public List<string> PlayerInventory { get; private set; }
        


        //Player Instance 
        public Player(string name, List<string> inventory)
        {
            PlayerName = name;
            PlayerInventory = inventory;
            
        }

      
    }
    
}
