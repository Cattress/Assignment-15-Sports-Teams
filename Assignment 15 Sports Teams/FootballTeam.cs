using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_Teams
{
    class FootballTeam : Team
    {
        private int totalGoals;
        private int totalRCard;

        public FootballTeam(string name)
        {
            this.name = name;
        }

        public double CalcAverageGoals()
        {
            double AverageGoals =(double) totalGoals / gamesPlayed;
            return AverageGoals;
        }
       
        public void AddGame(string result, int goals, int redCards)
        {
            if (result == "W")
            {
                gamesWon ++;
            }
            else if (result == "L")
            {
                gamesLost++;
            }
            gamesPlayed++;

            totalGoals = totalGoals + goals;
            totalRCard = totalRCard + redCards;
        }

    }

}
