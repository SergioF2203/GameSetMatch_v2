using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GameSetMatch
{
    public class Game
    {
        private readonly Player firstPlayer;
        private readonly Player secondPlayer;

        public int FirstPlayerScore { get; set; } = 0;
        public int SecondPlayerScore { get; set; } = 0;

        public Game()
        {
            firstPlayer = new Player();
            secondPlayer = new Player();
        }

        public Game(Player player1, Player player2)
        {
            firstPlayer = player1;
            secondPlayer = player2;
        }

        public void AddPoint(string playerName)
        {
            FirstPlayerScore = playerName == firstPlayer.PlayerName ? FirstPlayerScore + 1 : FirstPlayerScore;
            SecondPlayerScore = playerName == secondPlayer.PlayerName ? SecondPlayerScore + 1 : SecondPlayerScore;
        }

        public bool IsEndGame()
        {
            if ((FirstPlayerScore >= 4 || SecondPlayerScore >= 4) && (Math.Abs(FirstPlayerScore - SecondPlayerScore) >= 2))
            {
                return true;
            }

            return false;
        }

        public string NameWinners()
        {
            if (IsEndGame())
            {
                if (FirstPlayerScore > SecondPlayerScore)
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
