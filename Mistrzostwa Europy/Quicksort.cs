using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistrzostwa_Europy
{
    public class Quicksort
    {
        public static int[] teamScore = new int[4];
        public static int[] lostTeam = new int[4];
        public static int[] goalsTeam = new int[4];
        public static int[] totalTeam = new int[4];
        public static int[] tablica = new int[4];
        public static string[] kraje = new string[4];

        public static void quicksort(int[]array, string[] countries, int[]goalsTeam, int[]lostTeam,  int left
            , int right)
        {
            int i, j, x, c, z, q;
            string y;
            var v = array[(left + right) / 2];
            i = left;
            j = right;
            do
            {
                while (array[i] > v) i++;
                while (array[j] < v) j--;
                if (i <= j)
                {
                    x = array[i];
                    array[i] = array[j];
                    array[j] = x;
                    y = countries[i];
                    countries[i] = countries[j];
                    countries[j] = y;
                    z = goalsTeam[i];
                    goalsTeam[i] = goalsTeam[j];
                    goalsTeam[j] = z;
                    c = lostTeam[i];
                    lostTeam[i] = lostTeam[j];
                    lostTeam[j] = c;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (j > left) quicksort(array, countries, goalsTeam, lostTeam, left, j);
            if (i < right) quicksort(array, countries, goalsTeam, lostTeam, i, right);

        }

        public static void smallQuicksort(int[] array, string[] countries, int[] goalsTeam, int[] lostTeam,
            int[] teamScore, int left, int right)
        {
            int i, j, x, c, z, q;
            string y;
            var v = array[(left + right) / 2];
            i = left;
            j = right;
            do
            {
                while (array[i] > v) i++;
                while (array[j] < v) j--;
                if (i <= j)
                {
                    x = array[i];
                    array[i] = array[j];
                    array[j] = x;
                    y = countries[i];
                    countries[i] = countries[j];
                    countries[j] = y;
                    z = goalsTeam[i];
                    goalsTeam[i] = goalsTeam[j];
                    goalsTeam[j] = z;
                    c = lostTeam[i];
                    lostTeam[i] = lostTeam[j];
                    lostTeam[j] = c;
                    q = teamScore[i];
                    teamScore[i] = teamScore[j];
                    teamScore[j] = q;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (j > left) smallQuicksort( array, countries, goalsTeam, lostTeam, teamScore, left, j);
            if (i < right) smallQuicksort (array, countries, goalsTeam, lostTeam, teamScore, i, right);
        }
    }
}
