using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GameSetMatch
{
    class Game
    {
        private Player firstPlayer;
        private Player secondPlayer;

        private int firstPlayerScore = 0;
        private int secondPlayerScore = 0;

        public bool Tie { get; set; }

        public Game(string firstPlayerName, string secondPlayerName)
        {
            firstPlayer = new Player(firstPlayerName);
            secondPlayer = new Player(secondPlayerName);
        }

        public void AddPoint(string playerName)
        {
            firstPlayerScore = playerName == firstPlayer.PlayerName ? firstPlayerScore + 1 : firstPlayerScore;
            secondPlayerScore = playerName == secondPlayer.PlayerName ? secondPlayerScore + 1 : secondPlayerScore;
        }

        public bool IsEndGame()
        {
            if((firstPlayerScore >= 4 || secondPlayerScore >= 4) &&(Math.Abs(firstPlayerScore - secondPlayerScore) >= 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string NameWinners()
        {
            if (IsEndGame())
            {
                if(firstPlayerScore > secondPlayerScore)
                {
                    return firstPlayer.PlayerName;
                }
                else
                {
                    return secondPlayer.PlayerName;
                }
            }

            return string.Empty;
        }

    }
}
