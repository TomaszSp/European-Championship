using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Mistrzostwa_Europy
{
    public class Basket
    {
        public static List<string> ListA;
        public static List<string> ListB;
        public static List<string> ListC;
        public static List<string> ListD;
        public static string[] kosz = new string[16];

        public Basket()
        {
            ListA = new List<string>();
            ListB = new List<string>();
            ListC = new List<string>();
            ListD = new List<string>();
        }
        
        public static void Generate()
        {
            Console.WriteLine("Enter teams from 1st basket, separated with enter");
            for (int i = 0; i < 4; i++)
            {
                kosz[i] = Console.ReadLine();
                if(string.IsNullOrEmpty(kosz[i]))
                {
                    Console.WriteLine("A valid team name should have at least 1 character.");
                    i--;
                }
            }
            Console.WriteLine("Enter teams from 2nd basket, separated with enter");
            for (int i = 4; i < 8; i++)
            {
                kosz[i] = Console.ReadLine();
                if (string.IsNullOrEmpty(kosz[i]))
                {
                    Console.WriteLine("A valid team name should have at least 1 character.");
                    i--;
                }
            }
            Console.WriteLine("Enter teams from 3rd basket, separated with enter");
            for (int i = 8; i < 12; i++)
            {
                kosz[i] = Console.ReadLine();
                if (string.IsNullOrEmpty(kosz[i]))
                {
                    Console.WriteLine("A valid team name should have at least 1 character.");
                    i--;
                }
            }
            Console.WriteLine("Enter teams from 4th basket, separated with enter");
            for (int i = 12; i < 16; i++)
            {
                kosz[i] = Console.ReadLine();
                if (string.IsNullOrEmpty(kosz[i]))
                {
                    Console.WriteLine("A valid team name should have at least 1 character.");
                    i--;
                }
            }

            Console.WriteLine("Press any key to start the lottery.");
            Console.ReadKey();
        }

        public static void Lottery()
        {
            var obj = new Basket();
            var tab = new int[16];
            var random = new Random();
            int i = 0, m = 0;
            var list = new List<string>();
            var numbers = new List<int>();
            var grupy = new string[16];
            var team = new string[16];
            while (i < 16)
            {
                int l = 0, j = 0, k = 4;
                while (l < 4)
                {
                    var numb = random.Next(j, k);
                    if (!numbers.Contains(numb))
                    {
                        team[i] = kosz[numb];
                        j += 4;
                        k += 4;
                        numbers.Add(numb);
                        list.Add(team[i]);
                        i++;
                        l++;
                    }
                    else ;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Grupa A:");

            for (int x = 1; x < 5; x++)
            {
                Console.WriteLine(list[x-1]);
                ListA.Add(list[x-1]);
            }
            Console.WriteLine();
            Console.WriteLine("Grupa B:");
            for (int x = 5; x < 9; x++)
            {
                Console.WriteLine(list[x - 1]);
                ListB.Add(list[x-1]);
            }
            Console.WriteLine();
            Console.WriteLine("Grupa C:");
            for (int x = 9; x < 13; x++)
            {
                Console.WriteLine(list[x - 1]);
                ListC.Add(list[x - 1]);
            }
            Console.WriteLine();
            Console.WriteLine("Grupa D:");
            for (int x = 13; x < 17; x++)
            {
                Console.WriteLine(list[x - 1]);
                ListD.Add(list[x - 1]);
            }

            Console.WriteLine();
        }
    }
}
