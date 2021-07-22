using System;

namespace Week2Day3.partita
{
    internal class Menu
    {
        internal static void Start()
        {
            Console.WriteLine("Benvenuto al torneo!");
            int teams = 1;

            do
            {
                SoccerTeam.CreateTeam(teams);
                teams++;
            } while (teams <= 2);
            
        }
    }
}