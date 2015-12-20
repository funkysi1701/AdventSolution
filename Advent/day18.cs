using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day18
    {
        public static void day_18()
        {
            //Day 18 Challenge
            day18 d18 = new day18();
            Console.WriteLine("Day 18");
            Console.ReadLine();
            d18.readinput();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(d18.checkState());
            }
            Console.ReadLine();
        }
        public string[] input = File.ReadAllLines("../../day18.txt");
        public bool[,] xyinput = new bool[100,100];
        public bool[,] tmp = new bool[100, 100];
        public bool readinput()
        {
            string a ="";
            for (int i = 0; i < input.Length; i++)
            {
                a = input[i];
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == '.') xyinput[i, j] = false;
                    if (a[j] == '#') xyinput[i, j] = true;
                }
            }
            return xyinput[0,0];
        }

        public int checkState()
        {
            int on;
            int total=0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    on = count(i, j);
                    if (xyinput[i, j] && (on == 2 || on == 3)) {
                        tmp[i, j] = true; }
                    else tmp[i, j] = false;
                    if (!xyinput[i, j] && (on == 3)) {
                        tmp[i, j] = true; }
                    else tmp[i, j] = false;
                    if (tmp[i, j]) total++;
                }
            }
            for (int k = 0; k < 100; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    xyinput[k, l] = tmp[k, l];
                }
            }
            
            return total;
        }

        public int count(int x,int y)
        {
            int count = 0;
            if (x - 1 < 0 && y - 1 < 0) {
                if (xyinput[x, y + 1]) count++;
                if (xyinput[x + 1, y]) count++;
                if (xyinput[x + 1, y + 1]) count++;
            }
            else if (x - 1 < 0 && y+1 >99)
            {
                if (xyinput[x, y - 1]) count++;
                if (xyinput[x + 1, y - 1]) count++;
                if (xyinput[x + 1, y]) count++;
            }
            else if (x - 1 < 0) {
                if (xyinput[x, y - 1]) count++;
                if (xyinput[x, y + 1]) count++;
                if (xyinput[x + 1, y - 1]) count++;
                if (xyinput[x + 1, y]) count++;
                if (xyinput[x + 1, y + 1]) count++;
            }
            else if (y - 1 < 0 && x+1>99)
            {
                if (xyinput[x - 1, y]) count++;
                if (xyinput[x - 1, y + 1]) count++;
                if (xyinput[x, y + 1]) count++;
            }
            else if (y - 1 < 0) {
                if (xyinput[x - 1, y]) count++;
                if (xyinput[x - 1, y + 1]) count++;
                if (xyinput[x, y + 1]) count++;
                if (xyinput[x + 1, y]) count++;
                if (xyinput[x + 1, y + 1]) count++;
            }
            if (x + 1 > 99 && y + 1 > 99)
            {
                if (xyinput[x, y - 1]) count++;
                if (xyinput[x - 1, y]) count++;
                if (xyinput[x - 1, y - 1]) count++;
            }
            else if (x + 1 > 99 && y-1<0)
            {
                if (xyinput[x, y + 1]) count++;
                if (xyinput[x - 1, y]) count++;
                if (xyinput[x - 1, y + 1]) count++;
            }
            else if (x + 1 > 99)
            {
                if (xyinput[x, y - 1]) count++;
                if (xyinput[x, y + 1]) count++;
                if (xyinput[x - 1, y - 1]) count++;
                if (xyinput[x - 1, y]) count++;
                if (xyinput[x - 1, y + 1]) count++;
            }
            else if (y + 1 > 99 && x-1<0)
            {
                if (xyinput[x, y - 1]) count++;
                if (xyinput[x + 1, y]) count++;
                if (xyinput[x + 1, y - 1]) count++;
            }
            else if (y + 1 > 99)
            {
                if (xyinput[x - 1, y]) count++;
                if (xyinput[x - 1, y - 1]) count++;
                if (xyinput[x, y - 1]) count++;
                if (xyinput[x + 1, y]) count++;
                if (xyinput[x + 1, y - 1]) count++;
            }
            else if(x-1>0 && y-1>0 && x+1<99 && y+1<99){
                if (xyinput[x - 1, y - 1]) count++;
                if (xyinput[x - 1, y]) count++;
                if (xyinput[x - 1, y + 1]) count++;
                if (xyinput[x, y - 1]) count++;
                if (xyinput[x, y + 1]) count++;
                if (xyinput[x + 1, y - 1]) count++;
                if (xyinput[x + 1, y]) count++;
                if (xyinput[x + 1, y + 1]) count++;
            }
            return count;
        }
    }
}
