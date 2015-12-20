using System;
using System.IO;

namespace Advent
{
    public class day6
    {
        public bool[,] LightStatus = new bool[1000, 1000];

        public int[,] Brightness = new int[1000, 1000];
        public static void day_6()
        {
            //Day 6 Challenge
            day6 d6 = new day6();
            Console.WriteLine("Day 6");
            Console.ReadLine();
            for (int i = 0; i < d6.input3.Length; i++)
            {
                d6.lights(d6.input3[i]);
            }
            for (int a = 0; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    if (d6.LightStatus[a, b] == true) d6.light++;
                    d6.bness = d6.bness + d6.Brightness[a, b];
                }
            }
            Console.WriteLine(d6.light);
            Console.ReadLine();
            Console.WriteLine(d6.bness.ToString());
            Console.ReadLine();
        }
        public int light = 0;
        public int bness = 0;
        public string lights(string instructions)
        {
            if (instructions.Contains("toggle"))
            {
                instructions = instructions.Substring(7);
                string[] coord = instructions.Split('t');
                coord[1] = coord[1].Substring(7);
                string[] from = coord[0].Split(',');
                string[] to = coord[1].Split(',');
                int fromx = Convert.ToInt32(from[0]);
                int fromy = Convert.ToInt32(from[1]);
                int tox = Convert.ToInt32(to[0]);
                int toy = Convert.ToInt32(to[1]);
                for (int x = fromx; x < tox + 1; x++)
                {
                    for (int y = fromy; y < toy + 1; y++)
                    {
                        ++Brightness[x, y];
                        ++Brightness[x, y];
                        if (LightStatus[x, y] == true)
                        {
                            LightStatus[x, y] = false;
                        }
                        else {
                            LightStatus[x, y] = true;
                        }
                    }
                }
                return "toggle";
            }
            else if (instructions.Contains("turn on"))
            {
                instructions = instructions.Substring(8);
                string[] coord = instructions.Split('t');
                coord[1] = coord[1].Substring(7);
                string[] from = coord[0].Split(',');
                string[] to = coord[1].Split(',');
                int fromx = Convert.ToInt32(from[0]);
                int fromy = Convert.ToInt32(from[1]);
                int tox = Convert.ToInt32(to[0]);
                int toy = Convert.ToInt32(to[1]);
                //int numLights = (tox - fromx + 1) * (toy - fromy + 1);
                for (int x = fromx; x < tox + 1; x++)
                {
                    for (int y = fromy; y < toy + 1; y++)
                    {
                        LightStatus[x, y] = true;
                        ++Brightness[x, y];
                    }
                }
                //string from = instructions.Substring(0, 6);
                //string to = instructions.Substring()
                return "on";
            }
            else if (instructions.Contains("turn off"))
            {
                instructions = instructions.Substring(9);
                string[] coord = instructions.Split('t');
                coord[1] = coord[1].Substring(7);
                string[] from = coord[0].Split(',');
                string[] to = coord[1].Split(',');
                int fromx = Convert.ToInt32(from[0]);
                int fromy = Convert.ToInt32(from[1]);
                int tox = Convert.ToInt32(to[0]);
                int toy = Convert.ToInt32(to[1]);
                for (int x = fromx; x < tox + 1; x++)
                {
                    for (int y = fromy; y < toy + 1; y++)
                    {
                        LightStatus[x, y] = false;
                        if (Brightness[x, y] > 0) --Brightness[x, y];
                    }
                }
                return "off";
            }
            else return "error";
        }
        public string[] input3 =File.ReadAllLines("../../day6.txt");
    }
}
