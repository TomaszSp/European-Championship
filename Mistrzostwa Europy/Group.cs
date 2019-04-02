using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistrzostwa_Europy
{
    public class Group
    {
        public static string[] Country = new string[4];

        public static int[] teamScore = new int[4],
            teamScoreCopy = new int[4],
            goalsTeamCopy = new int [4],
            lostTeamCopy = new int[4],
            goalsTeam = new int [4],
            lostTeam = new int [4],
            totalTeam = new int [4];
        public static int scoreTeam0, scoreTeam1, scoreTeam2, scoreTeam3;
        public static Random random = new Random();


        public static void A1(List<string> List)
        {
            List.CopyTo(Country);

            var team0 = random.Next(0, 5);
            var team1 = random.Next(0, 5);
            var team2 = random.Next(0, 5);
            var team3 = random.Next(0, 5);

            Console.WriteLine(List[0] + " " + team0 + ":" + team1 + " " + List[1]);
            Console.WriteLine(List[2] + " " + team2 + ":" + team3 + " " + List[3]);

            goalsTeam[0] = team0;
            goalsTeam[1] = team1;
            goalsTeam[2] = team2;
            goalsTeam[3] = team3;
            lostTeam[0] = team1;
            lostTeam[1] = team0;
            lostTeam[2] = team3;
            lostTeam[3] = team2;

            if (team0 > team1)
            {
                scoreTeam0 = 3;
                scoreTeam1 = 0;
            }
            else if (team0 == team1)
            {
                scoreTeam0 = 1;
                scoreTeam1 = 1;
            }
            else
            {
                scoreTeam0 = 0;
                scoreTeam1 = 3;
            }

            if (team2 > team3)
            {
                scoreTeam2 = 3;
                scoreTeam3 = 0;
            }
            else if (team2 == team3)
            {
                scoreTeam2 = 1;
                scoreTeam3 = 1;
            }
            else
            {
                scoreTeam2 = 0;
                scoreTeam3 = 3;
            }

            teamScore[0] = scoreTeam0;
            teamScore[1] = scoreTeam1;
            teamScore[2] = scoreTeam2;
            teamScore[3] = scoreTeam3;
            for (int i = 0; i < 4; i++)
            {
                teamScoreCopy[i] = teamScore[i];
                goalsTeamCopy[i] = goalsTeam[i];
                lostTeamCopy[i] = lostTeam[i];
            }

            Console.WriteLine("STANDINGS AFTER 1ST ROUND: ");
            Console.WriteLine();
            Quicksort.quicksort(teamScore, Country, goalsTeam, lostTeam, 0, 3);

            for (int k = 0; k < 4; k++)
            {
                var j = 1;
                do
                {
                    if (k != j)
                    {
                        if (teamScore[k] == teamScore[j])
                        {
                            totalTeam[k] = goalsTeam[k] - lostTeam[k];
                            totalTeam[j] = goalsTeam[j] - lostTeam[j];

                            Quicksort.smallQuicksort(totalTeam, Country, goalsTeam, lostTeam, teamScore, 0, 1);
                            
                        }
                    }
                    j++;
                } while (j < 3);
            }


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Country[i] + " " + teamScore[i] + " Scored: " + goalsTeam[i] + " Lost: " + lostTeam[i]);
            }

            Console.WriteLine();
        }
        
        public static void A2(List<string> List)
        {

            var team0 = random.Next(0, 5);
            var team1 = random.Next(0, 5);
            var team2 = random.Next(0, 5);
            var team3 = random.Next(0, 5);

            for (int i = 0; i < 4; i++)
            {
                goalsTeam[i] = goalsTeamCopy[i];
                lostTeam[i] = lostTeamCopy[i];
                teamScore[i] = teamScoreCopy[i];
                Country[i] = List[i];
            }

            Console.WriteLine(List[0] + " " + team0 + ":" + team3 + " " + List[3]);
            Console.WriteLine(List[1] + " " + team1 + ":" + team2 + " " + List[2]);

            goalsTeam[0] += team0;
            goalsTeam[1] += team1;
            goalsTeam[2] += team2;
            goalsTeam[3] += team3;
            lostTeam[0] += team3;
            lostTeam[1] += team2;
            lostTeam[2] += team1;
            lostTeam[3] += team0;

            if (team1 > team2)
            {
                scoreTeam1 += 3;
                scoreTeam2 += 0;
            }
            else if (team1 == team2)
            {
                scoreTeam1 += 1;
                scoreTeam2 += 1;
            }
            else
            {
                scoreTeam1 += 0;
                scoreTeam2 += 3;
            }
            if (team0 > team3)
            {
                scoreTeam0 += 3;
                scoreTeam3 += 0;
            }
            else if (team0 == team3)
            {
                scoreTeam0 += 1;
                scoreTeam3 += 1;
            }
            else
            {
                scoreTeam0 += 0;
                scoreTeam3 += 3;
            }
            teamScore[0] = scoreTeam0;
            teamScore[1] = scoreTeam1;
            teamScore[2] = scoreTeam2;
            teamScore[3] = scoreTeam3;
            for (int i = 0; i < 4; i++)
            {
                goalsTeamCopy[i] = goalsTeam[i];
                lostTeamCopy[i] = lostTeam[i];
                teamScoreCopy[i] = teamScore[i];
            }
            Console.WriteLine("STANDINGS AFTER 2ND ROUND: ");
            Console.WriteLine();
            Quicksort.quicksort(teamScore, Country, goalsTeam, lostTeam, 0, 3);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Country[i] + " " + teamScore[i] + " Scored: " + goalsTeam[i] + " Lost: " + lostTeam[i]);
            }

            Console.WriteLine();
        }
        public static string[] A3(List<string> List)
        {

            var team0 = random.Next(0, 5);
            var team1 = random.Next(0, 5);
            var team2 = random.Next(0, 5);
            var team3 = random.Next(0, 5);

            for (int i = 0; i < 4; i++)
            {
                goalsTeam[i] = goalsTeamCopy[i];
                lostTeam[i] = lostTeamCopy[i];
                teamScore[i] = teamScoreCopy[i];
                Country[i] = List[i];
            }

            Console.WriteLine(List[0] + " " + team0 + ":" + team2 + " " + List[2]);
            Console.WriteLine(List[1] + " " + team1 + ":" + team3 + " " + List[3]);

            goalsTeam[0] += team0;
            goalsTeam[1] += team1;
            goalsTeam[2] += team2;
            goalsTeam[3] += team3;
            lostTeam[0] += team2;
            lostTeam[1] += team3;
            lostTeam[2] += team0;
            lostTeam[3] += team1;

            if (team0 > team2)
            {
                scoreTeam0 += 3;
                scoreTeam2 += 0;
            }
            else if (team0 == team2)
            {
                scoreTeam0 += 1;
                scoreTeam2 += 1;
            }
            else
            {
                scoreTeam0 += 0;
                scoreTeam2 += 3;
            }
            if (team1 > team3)
            {
                scoreTeam1 += 3;
                scoreTeam3 += 0;
            }
            else if (team1 == team3)
            {
                scoreTeam1 += 1;
                scoreTeam3 += 1;
            }
            else
            {
                scoreTeam1 += 0;
                scoreTeam3 += 3;
            }
            teamScore[0] = scoreTeam0;
            teamScore[1] = scoreTeam1;
            teamScore[2] = scoreTeam2;
            teamScore[3] = scoreTeam3;

            Console.WriteLine("STANDINGS AFTER 3RD ROUND: ");
            Console.WriteLine();
            Quicksort.quicksort(teamScore, Country, goalsTeam, lostTeam, 0, 3);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Country[i] + " " + teamScore[i] + " Scored: " + goalsTeam[i] + " Lost: " + lostTeam[i]);
            }

            Console.WriteLine();
            return new string[] {Country[0], Country[1]};
        }
    }
}
