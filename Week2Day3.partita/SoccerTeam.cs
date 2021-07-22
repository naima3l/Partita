using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3.partita
{
    class SoccerTeam 
    {
        internal static List<SoccerPlayer> Team1 = new List<SoccerPlayer>();
        internal static List<SoccerPlayer> Team2 = new List<SoccerPlayer>();

        internal static List<Defender> ITDefenders = new List<Defender>()
        {
        new Defender("Giorgio", "Chiellini", 39,1, "Difensore",2,3 ),
        new Defender("Leonardo", "Bonucci", 36, 2, "Difensore",3,4 ),
        new Defender("Leonardo", "Spinazzola", 30, 3,"Difensore",4,5 ),
        new Defender("Emerson", "Palmieri", 27, 4, "Difensore",5,3 ),
        new Defender("Alessandro", "Florenzi", 28, 5,"Difensore",6,4 ),
        new Defender("Alessio", "Romagnoli", 32, 6,"Difensore",7,5 ),
        new Defender("Davide", "Calabria", 25, 7,"Difensore",8,10 ),
        new Defender("Rafael", "Toloi", 23, 8,"Difensore",9,5 )
        };

        internal static List<Striker> ITStrikers = new List<Striker>
        {
            new Striker("Lorenzo","Insigne",32,1, "Attaccante", 10, 15),
            new Striker("Federico","Chiesa",27,2, "Attaccante", 11, 8),
            new Striker("Ciro","Immobile",29,3, "Attaccante", 12, 7),
            new Striker("Domenico","Berardi",30,4, "Attaccante", 13, 20),
            new Striker("Moise","Kean",19,5, "Attaccante", 14, 2),
            new Striker("Andrea","Belotti",32,6, "Attaccante", 15, 14)
        };

        internal static List<Midfielder> ITMidfielders = new List<Midfielder>
        {
            new Midfielder("Manuel","Locatelli",28,1, "Centrocampista", 16, 15),
            new Midfielder("Nicolò","Barella",27,2, "Centrocampista", 17, 8),
            new Midfielder("Marco","Verratti",29,3, "Centrocampista", 18, 7),
            new Midfielder("Matteo","Pessina",30,4, "Centrocampista", 19, 20),
            new Midfielder("Lorenzo","Pellegrini",19,5, "Centrocampista", 20, 2),
            new Midfielder("Sandro","Tonali",23,6, "Centrocampista", 21, 14)
        };

        internal static List<Goalkeeper> ITGoalkeepers = new List<Goalkeeper>
        {
            new Goalkeeper("Gigio","Donnarumma",22,1, "Portiere", 1, 15),
            new Goalkeeper("Gigi","Buffon",38,2, "Portiere", 1, 8),
            new Goalkeeper("Walter","Zenga",41,3, "Portiere", 1, 7)
        };

        internal static List<Referee> Referees = new List<Referee>
        {
            new Referee("Howard","Webb",22,1,15),
            new Referee("Pierluigi","Collina",38,2,8),
            new Referee("Stèphanie","Frappet",41,3,7)
        };

        internal static List<Defender> EGDefenders = new List<Defender>()
        {
        new Defender("Harry", "Maguire", 39,1, "Difensore",2,3 ),
        new Defender("Luke", "Shaw", 36, 2, "Difensore",3,4 ),
        new Defender("Tyrone", "Mings", 30, 3,"Difensore",4,5 ),
        new Defender("Kieran", "Tripper", 27, 4, "Difensore",5,3 ),
        new Defender("Kyle", "Walker", 28, 5,"Difensore",6,4 ),
        new Defender("John", "Stones", 32, 6,"Difensore",7,5 ),
        new Defender("Ben", "White", 25, 7,"Difensore",8,10 ),
        new Defender("Reece", "James", 23, 8,"Difensore",9,5 )
        };

        internal static List<Striker> EGStrikers = new List<Striker>
        {
            new Striker("Harry","Kane",32,1, "Attaccante", 10, 15),
            new Striker("Raheem","Sterling",27,2, "Attaccante", 11, 8),
            new Striker("Marcus","Rashford",29,3, "Attaccante", 12, 7),
            new Striker("Ollie","Watkins",30,4, "Attaccante", 13, 20),
            new Striker("Danny","Ings",19,5, "Attaccante", 14, 2),
            new Striker("Callum","Hudson",32,6, "Attaccante", 15, 14)
        };

        internal static List<Midfielder> EGMidfielders = new List<Midfielder>
        {
            new Midfielder("Jack","Grealish",28,1, "Centrocampista", 16, 15),
            new Midfielder("Bukayo","Saka",27,2, "Centrocampista", 17, 8),
            new Midfielder("Phil","Foden",29,3, "Centrocampista", 18, 7),
            new Midfielder("Kalvin","Phillips",30,4, "Centrocampista", 19, 20),
            new Midfielder("Jadon","Sancho",19,5, "Centrocampista", 20, 2),
            new Midfielder("Mason","Mount",23,6, "Centrocampista", 21, 14)
        };

        internal static List<Goalkeeper> EGGoalkeepers = new List<Goalkeeper>
        {
            new Goalkeeper("Jordan","Pickord",22,1, "Portiere", 1, 15),
            new Goalkeeper("Sam","Johnstone",38,2, "Portiere", 1, 8),
            new Goalkeeper("Dean","Henderson",41,3, "Portiere", 1, 7)
        };

        public SoccerTeam()
        {

        }

        
        internal static void CreateTeam(int v)
        {

            int choice = 0, df = 0, at = 0, cc = 0, p = 0;

            if (v == 1)
            {
                Console.WriteLine("Creiamo la squadra italiana!");
                //difensori IT
                do
                {
                    Console.WriteLine("Scegli difensore in base al codice");
                    foreach (Defender defender in ITDefenders)
                    {
                        Console.WriteLine($"Codice : {defender.Code} Nome: {defender.Name}, Cognome : {defender.Surname}");

                    }
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                    {
                        Console.WriteLine("Scelta non valida!");
                    }

                    foreach (Defender defender in ITDefenders)
                    {
                        if (choice == defender.Code)
                        {
                            SoccerPlayer sp = new SoccerPlayer(defender.Name, defender.Surname, defender.Age, defender.Code, defender.Role, defender.Num);
                            Team1.Add(sp);
                            defender.Code = -1;
                        }

                    }
                    df++;


                } while (df < 4);

                //attaccanti IT
                do
                {
                    Console.WriteLine("Scegli gli attaccanti in base al codice");
                    foreach (Striker striker in ITStrikers)
                    {
                        Console.WriteLine($"Codice : {striker.Code} Nome: {striker.Name}, Cognome : {striker.Surname}");

                    }
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                    {
                        Console.WriteLine("Scelta non valida!");
                    }

                    foreach (Striker striker in ITStrikers)
                    {
                        if (choice == striker.Code)
                        {
                            SoccerPlayer sp = new SoccerPlayer(striker.Name, striker.Surname, striker.Age, striker.Code, striker.Role, striker.Num);
                            Team1.Add(sp);
                            striker.Code = -1;
                        }

                    }
                    at++;


                } while (at < 3);

                //centrocampisti IT
                do
                {
                    Console.WriteLine("Scegli i centrocampisti in base al codice");
                    foreach (Midfielder midfielder in ITMidfielders)
                    {
                        Console.WriteLine($"Codice : {midfielder.Code} Nome: {midfielder.Name}, Cognome : {midfielder.Surname}");

                    }
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                    {
                        Console.WriteLine("Scelta non valida!");
                    }

                    foreach (Midfielder midfielder in ITMidfielders)
                    {
                        if (choice == midfielder.Code)
                        {
                            SoccerPlayer sp = new SoccerPlayer(midfielder.Name, midfielder.Surname, midfielder.Age, midfielder.Code, midfielder.Role, midfielder.Num);
                            Team1.Add(sp);
                            midfielder.Code = -1;
                        }

                    }
                    cc++;


                } while (cc < 3);

                //portiere IT
                do
                {
                    Console.WriteLine("Scegli il portiere in base al codice");
                    foreach (Goalkeeper goalkeeper in ITGoalkeepers)
                    {
                        Console.WriteLine($"Codice : {goalkeeper.Code} Nome: {goalkeeper.Name}, Cognome : {goalkeeper.Surname}");

                    }
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                    {
                        Console.WriteLine("Scelta non valida!");
                    }

                    foreach (Goalkeeper goalkeeper in ITGoalkeepers)
                    {
                        if (choice == goalkeeper.Code)
                        {
                            SoccerPlayer sp = new SoccerPlayer(goalkeeper.Name, goalkeeper.Surname, goalkeeper.Age, goalkeeper.Code, goalkeeper.Role, goalkeeper.Num);
                            Team1.Add(sp);
                            goalkeeper.Code = -1;
                        }

                    }
                    p++;


                } while (p < 1);
            }
            else
            {
                Console.WriteLine("Creiamo la squadra inglese!");
                do
                {
                    Console.WriteLine("Scegli difensore in base al codice");
                    foreach (Defender defender in EGDefenders)
                    {
                        Console.WriteLine($"Codice : {defender.Code} Nome: {defender.Name}, Cognome : {defender.Surname}");

                    }
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                    {
                        Console.WriteLine("Scelta non valida!");
                    }

                    foreach (Defender defender in EGDefenders)
                    {
                        if (choice == defender.Code)
                        {
                            SoccerPlayer sp = new SoccerPlayer(defender.Name, defender.Surname, defender.Age, defender.Code, defender.Role, defender.Num);
                            Team2.Add(sp);
                            defender.Code = -1;
                        }

                    }
                    df++;


                } while (df < 4);

                //attaccanti IT
                do
                {
                    Console.WriteLine("Scegli gli attaccanti in base al codice");
                    foreach (Striker striker in EGStrikers)
                    {
                        Console.WriteLine($"Codice : {striker.Code} Nome: {striker.Name}, Cognome : {striker.Surname}");

                    }
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                    {
                        Console.WriteLine("Scelta non valida!");
                    }

                    foreach (Striker striker in EGStrikers)
                    {
                        if (choice == striker.Code)
                        {
                            SoccerPlayer sp = new SoccerPlayer(striker.Name, striker.Surname, striker.Age, striker.Code, striker.Role, striker.Num);
                            Team2.Add(sp);
                            striker.Code = -1;
                        }

                    }
                    at++;


                } while (at < 3);

                //centrocampisti IT
                do
                {
                    Console.WriteLine("Scegli i centrocampisti in base al codice");
                    foreach (Midfielder midfielder in EGMidfielders)
                    {
                        Console.WriteLine($"Codice : {midfielder.Code} Nome: {midfielder.Name}, Cognome : {midfielder.Surname}");

                    }
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                    {
                        Console.WriteLine("Scelta non valida!");
                    }

                    foreach (Midfielder midfielder in EGMidfielders)
                    {
                        if (choice == midfielder.Code)
                        {
                            SoccerPlayer sp = new SoccerPlayer(midfielder.Name, midfielder.Surname, midfielder.Age, midfielder.Code, midfielder.Role, midfielder.Num);
                            Team2.Add(sp);
                            midfielder.Code = -1;
                        }

                    }
                    cc++;


                } while (cc < 3);

                //portiere IT
                do
                {
                    Console.WriteLine("Scegli il portiere in base al codice");
                    foreach (Goalkeeper goalkeeper in EGGoalkeepers)
                    {
                        Console.WriteLine($"Codice : {goalkeeper.Code} Nome: {goalkeeper.Name}, Cognome : {goalkeeper.Surname}");

                    }
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                    {
                        Console.WriteLine("Scelta non valida!");
                    }

                    foreach (Goalkeeper goalkeeper in EGGoalkeepers)
                    {
                        if (choice == goalkeeper.Code)
                        {
                            SoccerPlayer sp = new SoccerPlayer(goalkeeper.Name, goalkeeper.Surname, goalkeeper.Age, goalkeeper.Code, goalkeeper.Role, goalkeeper.Num);
                            Team2.Add(sp);
                            goalkeeper.Code = -1;
                        }

                    }
                    p++;


                } while (p < 1);
            }

           if(v == 2)
            { Console.WriteLine("Perfetto! Abbiamo creato le due squadre! Adesso devi scegliere l'arbitro in base al suo codice.");
                foreach (Referee referee in Referees)
                {
                    Console.WriteLine($"Codice : {referee.Code} Nome: {referee.Name}, Cognome : {referee.Surname}");

                }
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0)
                {
                    Console.WriteLine("Scelta non valida!");
                }

                foreach (Referee referee in Referees)
                {
                    if (choice == referee.Code)
                    {
                        SoccerPlayer sp = new SoccerPlayer(referee.Name, referee.Surname, referee.Age, referee.Code, "Arbitro", 0);
                        Team1.Add(sp);
                        Team2.Add(sp);
                    }

                }

                Console.WriteLine("La squadra italiana che hai scelto è :");
                foreach (SoccerPlayer sp in Team1)
                {
                    Console.WriteLine($"{sp.Name} {sp.Surname} {sp.Role}");
                }

                Console.WriteLine("\nLa squadra inglese che hai scelto è :");
                foreach (SoccerPlayer sp in Team2)
                {
                    Console.WriteLine($"{sp.Name} {sp.Surname} {sp.Role}");
                }

                Console.WriteLine("\nPossiamo iniziare la partita!");
            }
        }
    }
}
