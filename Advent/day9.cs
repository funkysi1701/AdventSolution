using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day9
    {
        public enum Destination
        {
            Faerun = 0,
            Tristram = 1,
            Tambi = 2,
            Norrath = 3,
            Snowdin = 4,
            Straylight = 5,
            AlphaCentauri = 6,
            Arbre = 7
        }
        public int[,] Distances = new int[8, 8];

        public void setup()
        {
            Distances[(int)Destination.Faerun, (int)Destination.Tristram] = 65;
            Distances[(int)Destination.Faerun, (int)Destination.Tambi] = 129;
            Distances[(int)Destination.Faerun, (int)Destination.Norrath] = 144;
            Distances[(int)Destination.Faerun, (int)Destination.Snowdin] = 71;
            Distances[(int)Destination.Faerun, (int)Destination.Straylight] = 137;
            Distances[(int)Destination.Faerun, (int)Destination.AlphaCentauri] = 3;
            Distances[(int)Destination.Faerun, (int)Destination.Arbre] = 149;

            Distances[(int)Destination.Tristram, (int)Destination.Tambi] = 63;
            Distances[(int)Destination.Tristram, (int)Destination.Norrath] = 4;
            Distances[(int)Destination.Tristram, (int)Destination.Snowdin] = 105;
            Distances[(int)Destination.Tristram, (int)Destination.Straylight] = 125;
            Distances[(int)Destination.Tristram, (int)Destination.AlphaCentauri] = 55;
            Distances[(int)Destination.Tristram, (int)Destination.Arbre] = 14;
            Distances[(int)Destination.Tristram, (int)Destination.Faerun] = 65;

            Distances[(int)Destination.Tambi, (int)Destination.Tristram] = 63;
            Distances[(int)Destination.Tambi, (int)Destination.Norrath] = 68;
            Distances[(int)Destination.Tambi, (int)Destination.Snowdin] = 52;
            Distances[(int)Destination.Tambi, (int)Destination.Straylight] = 65;
            Distances[(int)Destination.Tambi, (int)Destination.AlphaCentauri] = 22;
            Distances[(int)Destination.Tambi, (int)Destination.Arbre] = 143;
            Distances[(int)Destination.Tambi, (int)Destination.Faerun] = 129;

            Distances[(int)Destination.Norrath, (int)Destination.Tambi] = 68;
            Distances[(int)Destination.Norrath, (int)Destination.Tristram] = 4;
            Distances[(int)Destination.Norrath, (int)Destination.Snowdin] = 8;
            Distances[(int)Destination.Norrath, (int)Destination.Straylight] = 23;
            Distances[(int)Destination.Norrath, (int)Destination.AlphaCentauri] = 136;
            Distances[(int)Destination.Norrath, (int)Destination.Arbre] = 115;
            Distances[(int)Destination.Norrath, (int)Destination.Faerun] = 144;

            Distances[(int)Destination.Snowdin, (int)Destination.Tambi] = 52;
            Distances[(int)Destination.Snowdin, (int)Destination.Norrath] = 8;
            Distances[(int)Destination.Snowdin, (int)Destination.Tristram] = 105;
            Distances[(int)Destination.Snowdin, (int)Destination.Straylight] = 101;
            Distances[(int)Destination.Snowdin, (int)Destination.AlphaCentauri] = 84;
            Distances[(int)Destination.Snowdin, (int)Destination.Arbre] = 96;
            Distances[(int)Destination.Snowdin, (int)Destination.Faerun] = 71;

            Distances[(int)Destination.Straylight, (int)Destination.Tambi] = 65;
            Distances[(int)Destination.Straylight, (int)Destination.Norrath] = 23;
            Distances[(int)Destination.Straylight, (int)Destination.Snowdin] = 101;
            Distances[(int)Destination.Straylight, (int)Destination.Tristram] = 125;
            Distances[(int)Destination.Straylight, (int)Destination.AlphaCentauri] = 107;
            Distances[(int)Destination.Straylight, (int)Destination.Arbre] = 14;
            Distances[(int)Destination.Straylight, (int)Destination.Faerun] = 137;

            Distances[(int)Destination.AlphaCentauri, (int)Destination.Tambi] = 22;
            Distances[(int)Destination.AlphaCentauri, (int)Destination.Norrath] = 136;
            Distances[(int)Destination.AlphaCentauri, (int)Destination.Snowdin] = 84;
            Distances[(int)Destination.AlphaCentauri, (int)Destination.Straylight] = 107;
            Distances[(int)Destination.AlphaCentauri, (int)Destination.Tristram] = 55;
            Distances[(int)Destination.AlphaCentauri, (int)Destination.Arbre] = 46;
            Distances[(int)Destination.AlphaCentauri, (int)Destination.Faerun] = 3;

            Distances[(int)Destination.Arbre, (int)Destination.Tambi] = 143;
            Distances[(int)Destination.Arbre, (int)Destination.Norrath] = 115;
            Distances[(int)Destination.Arbre, (int)Destination.Snowdin] = 96;
            Distances[(int)Destination.Arbre, (int)Destination.Straylight] = 14;
            Distances[(int)Destination.Arbre, (int)Destination.AlphaCentauri] = 46;
            Distances[(int)Destination.Arbre, (int)Destination.Tristram] = 14;
            Distances[(int)Destination.Arbre, (int)Destination.Faerun] = 149;
        }

        public int TotalDistance(bool maxormin)
        {
            int[] total = new int[40320];
            int count = 0;
            //total[0]= Distances[0, 1] + Distances[1, 2] + Distances[2, 3] + Distances[3, 4] + Distances[4, 5] + Distances[5, 6] + Distances[6, 7];
            //total = Distances[0, 1] + Distances[1, 2] + Distances[2, 3] + Distances[3, 4] + Distances[4, 5] + Distances[5, 7] + Distances[7, 6];
            //total = Distances[0, 1] + Distances[1, 2] + Distances[2, 3] + Distances[3, 4] + Distances[4, 5] + Distances[5, 6] + Distances[6, 7];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == j) continue;
                    for (int k = 0; k < 8; k++)
                    {
                        if (i == k) continue;
                        if (j == k) continue;
                        for (int l = 0; l < 8; l++)
                        {
                            if (i == l) continue;
                            if (j == l) continue;
                            if (k == l) continue;
                            for (int m = 0; m < 8; m++)
                            {
                                if (i == m) continue;
                                if (j == m) continue;
                                if (k == m) continue;
                                if (l == m) continue;
                                for (int n = 0; n < 8; n++)
                                {
                                    if (i == n) continue;
                                    if (j == n) continue;
                                    if (k == n) continue;
                                    if (l == n) continue;
                                    if (m == n) continue;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (i == p) continue;
                                        if (j == p) continue;
                                        if (k == p) continue;
                                        if (l == p) continue;
                                        if (m == p) continue;
                                        if (n == p) continue;
                                        for (int q = 0; q < 8; q++)
                                        {
                                            if (i == q) continue;
                                            if (j == q) continue;
                                            if (k == q) continue;
                                            if (l == q) continue;
                                            if (m == q) continue;
                                            if (n == q) continue;
                                            if (p == q) continue;
                                            total.Count();
                                            total[count] = Distances[i, j] + Distances[j, k] + Distances[k, l] + Distances[l, m] + Distances[m, n] + Distances[n, p] + Distances[p, q];
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (maxormin) return total.Min();
            else return total.Max();
        }
    }
}
