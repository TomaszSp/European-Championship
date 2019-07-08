using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mistrzostwa_Europy
{
    public class Champions
    {
        public static string[] AdvanceA = new string[2];
        public static string[] AdvanceB = new string[2];
        public static string[] AdvanceC = new string[2];
        public static string[] AdvanceD = new string[2];
        public static Random random = new Random();
        private static string semi0, semi1, semi2, semi3, final0, final1, champ;

        public static void ChampionA()
        {
            AdvanceA = Group.A3(Basket.ListA);
        }
        public static void ChampionB()
        {
            AdvanceB = Group.A3(Basket.ListB);
        }
        public static void ChampionC()
        {
            AdvanceC = Group.A3(Basket.ListC);
        }
        public static void ChampionD()
        {
            AdvanceD = Group.A3(Basket.ListD);
        }
    
        public static string Tournament(string tm0, string tm1)
        {
            Console.WriteLine();
            var team0 = random.Next(0, 5);
            var team1 = random.Next(0, 5);
            Console.WriteLine(tm0 + " " + team0 + ":" + team1 + " " + tm1);

            if (team0 > team1)
                return tm0;
            else if (team1 > team0)
                return tm1;
            else
            {
                var OT0 = random.Next(0, 2);
                var OT1 = random.Next(0, 2);
                var updatedScore0 = OT0 + team0;
                var updatedScore1 = OT1 + team1;

                Console.WriteLine("EXTRATIME RESULT:");
                Console.WriteLine(tm0 + " " + updatedScore0 + ":" + updatedScore1 + " " + tm1);
                if (OT0 > OT1)
                    return tm0;
                else if (OT1 > OT0)
                    return tm1;
                else
                {
                    int p0 = new int();
                    int p1 = new int();

                    for (int i = 0; i < 5; i++)
                    {
                        var penalty0 = random.Next(2) == 0;
                        var penalty1 = random.Next(2) == 0;
                        if (penalty0) p0++;
                        if (penalty1) p1++;

                        if ((Math.Abs(p0 - p1) > 2 && (i > 2)) || (Math.Abs(p0 - p1) > 1 && (i > 3)))
                            break;
                    }

                    do
                    {
                        var penalty0 = random.Next(2) == 0;
                        var penalty1 = random.Next(2) == 0;
                        if (penalty0) p0++;
                        if (penalty1) p1++;
                    } while (p0 == p1);

                    Console.WriteLine("PENALTIES RESULT:");
                    Console.WriteLine(tm0 + " " + p0 + ":" + p1 + " " + tm1);

                    if (p0 > p1)
                        return tm0;
                    else
                        return tm1;
                }
            }
        }

        public static void Quarter()
        {
            Console.WriteLine();
            Console.WriteLine("QUARTERFINALS: ");
            Console.WriteLine("------------------");
            semi0 = Tournament(Champions.AdvanceA[0], Champions.AdvanceB[1]);
            semi1 = Tournament(Champions.AdvanceC[0], Champions.AdvanceD[1]);
            semi2 = Tournament(Champions.AdvanceA[1], Champions.AdvanceB[0]);
            semi3 = Tournament(Champions.AdvanceC[1], Champions.AdvanceD[0]);
        }

        public static void Semis()
        {
            Console.WriteLine();
            Console.WriteLine("SEMIFINALS: ");
            Console.WriteLine("------------------");
            final0 = Tournament(semi0, semi1);
            final1 = Tournament(semi2, semi3);
        }

        public static void Finals()
        {
            Console.WriteLine();
            Console.WriteLine("GRAND FINAL: ");
            Console.WriteLine("------------------");
            champ = Tournament(final0, final1);
            Console.WriteLine();
            Console.WriteLine(champ + " IS THE NEW EUROPE FOOTBALL CHAMPION");
            Console.ReadKey();
        }
    }
}
