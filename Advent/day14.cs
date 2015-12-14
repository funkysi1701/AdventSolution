using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day14
    {
        public int[] Rudolph = new int[4] { 22, 8, 0, 165 };
        public int[] Cupid = new int[4] { 8, 17, 0, 114 };
        public int[] Prancer = new int[4] { 18, 6, 0, 103 };
        public int[] Donner = new int[4] { 25, 6, 0, 145 };
        public int[] Dasher = new int[4] { 11, 12, 0, 125 };
        public int[] Comet = new int[4] { 21, 6, 0, 121 };
        public int[] Blitzen = new int[4] { 18, 3, 0, 50 };
        public int[] Vixen = new int[4] { 20, 4, 0, 75 };
        public int[] Dancer = new int[4] { 7, 20, 0, 119 };
        public int CalcDistance(int[] Reindeer, int time)
        {
            int dist = 0;
            while (time > -1)
            {
                int t = 0;
                if (time < Reindeer[1]) t = time;
                else t = Reindeer[1];
                dist = dist + (Reindeer[0] * t);
                time = time - Reindeer[3];
                time = time - Reindeer[1];
            }
            return dist;
        }

        public int FastestPart2()
        {
            int time = 2503;
            int[] d = new int[9];
            int[] score = new int[9];
            int max;
            int maxIndex;
            for (int i = 1; i < time; i++)
            {
                d[0] = CalcDistance(Rudolph, i);
                d[1] = CalcDistance(Cupid, i);
                d[2] = CalcDistance(Prancer, i);
                d[3] = CalcDistance(Donner, i);
                d[4] = CalcDistance(Dasher, i);
                d[5] = CalcDistance(Comet, i);
                d[6] = CalcDistance(Blitzen, i);
                d[7] = CalcDistance(Vixen, i);
                d[8] = CalcDistance(Dancer, i);
                max = 0;
                maxIndex = 0;
                for (int j = 0; j < 9; j++)
                {
                    if (d[j] > max)
                    {
                        maxIndex = j;
                        max = d[j];
                    }
                }
                score[maxIndex]++;
            }
            return score.Max();
        }
        public int FastestPart1()
        {
            int time = 2503;
            int[] d = new int[9];
            d[0] = CalcDistance(Rudolph, time);
            d[1] = CalcDistance(Cupid, time);
            d[2] = CalcDistance(Prancer, time);
            d[3] = CalcDistance(Donner, time);
            d[4] = CalcDistance(Dasher, time);
            d[5] = CalcDistance(Comet, time);
            d[6] = CalcDistance(Blitzen, time);
            d[7] = CalcDistance(Vixen, time);
            d[8] = CalcDistance(Dancer, time);
            return d.Max();
        }
    }
}
