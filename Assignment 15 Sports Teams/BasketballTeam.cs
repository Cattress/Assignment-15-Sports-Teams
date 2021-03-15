using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_Teams
{
    class BasketballTeam : Team
    {
        private int totalBaskets;
        private int totalBlocks;
       

        public BasketballTeam(string name)
        {
        }

        public double CalcAverageSteal()
        {
            double averageSteal = (double)totalBlocks / totalBaskets;
            return averageSteal;
        }

        public void AddGame(string result, int baskets, int blocks)
        {
            if (result == "W")
            {
                gamesWon++;
            }
            else if (result == "L")
            {
                gamesLost++;
            }
            gamesPlayed++;

            totalBaskets = totalBaskets + baskets;
            totalBlocks = totalBlocks + blocks;
        }
       
    }
}
