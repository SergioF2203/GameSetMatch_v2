using System;
using System.Collections.Generic;
using System.Text;

namespace GameSetMatch
{
    public class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            PlayerName = name;
        }

        public Player()
        {
            PlayerName = string.Empty;
        }
    }
}
