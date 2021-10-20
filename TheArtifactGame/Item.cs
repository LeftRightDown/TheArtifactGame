using System;
using System.Collections.Generic;
using System.Text;

namespace TheArtifactGame
{
    class Item
    {


        public string Name = "Stone";
        public string Description = "Logically Flawed";


        //constructor
        public Item()
        {
            string[] Items = { "The Artifact", "Gauge Tablet", "Schematics","Key Card" };
            string[] Descriptions = { " A Relic of a long lost civilization known as the Xurr.\nRumored to hold the long lost secretes to their technological advanceds.",
         "Touch screen tablet that displays gauge information","Logically Flawed"};

            //In-game Items
            Item Artifact = new Item();
            Artifact.Name = "The Artifact";
            Artifact.Description = "A Relic of a long lost civilization known as the Xurr.\nRumored to hold the long lost secretes to their technological advanceds.";

            Item Tablet = new Item();
            Tablet.Name = "Gauge Tablet";
            Tablet.Description = "Touch screen tablet that displays gauge information";

            //Instantiate random 
            Random randomNumber = new Random();
            int number;
            //Next (Int32) returns a non-negative rnadom number less than the max
            number = randomNumber.Next(Items.Length);

            Name = Items[number];
            Description = Descriptions[number];
            Console.WriteLine($"\nYou found a {Name} {Description}\n");
        }
    }
}
