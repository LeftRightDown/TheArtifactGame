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
        public List<Item> PlayerInventory = new List<Item>();
        


        //Player Instance 
        public Player(string name)
        {
            PlayerName = name;
           
            
        }
        public void Displayinventory()
        {
            if (PlayerInventory.Count > 0)
            {
                int index = 1;
                for (int i = 0; i < PlayerInventory.Count; i++)
                {
                 WriteLine($"{index}: [{PlayerInventory[i].Name}]");
                 WriteLine(PlayerInventory[i].Description);
                    index++;
                }
            }
            else
            {
                WriteLine("There is Nothing in your Inventory");
            }



        }
    }
    
}
