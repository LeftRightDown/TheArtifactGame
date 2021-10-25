using System;
using System.Collections.Generic;
using System.Text;

namespace TheArtifactGame
{
    class Robot : Player
    {
        public string RobotName { get; set; }

        public Robot(string name) :base(name)
        {
            RobotName = name;


        }
    }
}
