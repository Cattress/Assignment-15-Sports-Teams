using System;

namespace Assignment_15_Sports_Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballTeam t1 = new FootballTeam("TH");

            Console.WriteLine(t1.ReturnStats());

        }
    }
}
