using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_Teams
{
    class Team
    {
        protected string name;
        protected int gamesPlayed;
        protected int gamesWon;
        protected int gamesLost;

        public double CalcWinPercent(string name)
        {
            double winPercent = (double) gamesPlayed / gamesWon;
            winPercent = winPercent*100;

            return winPercent;
        }

        public string ReturnStats()
        {
            string teamStats = "Team: "+ name+ "Games Played: "+ gamesPlayed+ "Won: "+ gamesWon +"Lost: "+gamesPlayed;
            return teamStats;
        }

       public void AddGame(string teamStats)
        {
            // finish this or die
        }
    }
}
