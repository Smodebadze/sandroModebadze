using System;
using System.Collections.Generic;
using System.Text;

namespace lesson15
{
    internal class Player
    {

        public string Name { get; set; }
        public int Score { get; set; }
        public bool Active { get; set; }


        public Player()
        {

        }
        public Player(string name, int score, bool active)
        {
            Name = name;
            Score = score;
            Active = active;
        }



    }
}
