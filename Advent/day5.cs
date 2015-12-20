using System;
using System.IO;
using System.Linq;

namespace Advent
{
    public class day5
    {
        public int nice = 0;
        public int nice2 = 0;
        public static void day_5()
        {
            //Day 5 Challenge
            day5 d5 = new day5();
            Console.WriteLine("Day 5");
            Console.ReadLine();
            for (int i = 0; i < d5.input2.Length; i++)
            {
                if (d5.niceString(d5.input2[i])) d5.nice++;
                if (d5.niceString2(d5.input2[i])) d5.nice2++;
            }
            Console.WriteLine(d5.nice.ToString());
            Console.ReadLine();
            Console.WriteLine(d5.nice2.ToString());
            Console.ReadLine();
        }
        public bool niceString(string naughtyList)
        {
            bool ab = naughtyList.Contains("ab");
            bool cd = naughtyList.Contains("cd");
            bool pq = naughtyList.Contains("pq");
            bool xy = naughtyList.Contains("xy");
            bool duplicates = false;
            int a = naughtyList.Split('a').Length - 1;
            int e = naughtyList.Split('e').Length - 1;
            int i = naughtyList.Split('i').Length - 1;
            int o = naughtyList.Split('o').Length - 1;
            int u = naughtyList.Split('u').Length - 1;
            bool vowels = (a + e + i + o + u > 2);
            for (int j = 0; j < naughtyList.Count() - 1; j++)
            {
                if (naughtyList[j] == naughtyList[j + 1])
                {
                    duplicates = true;
                }
            }
            if (!ab && !cd && !pq && !xy && vowels && duplicates)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool niceString2(string naughtyList)
        {
            bool oneapart = false;
            bool twochars = false;

            for (int j = 0; j < naughtyList.Count() - 2; j++)
            {
                if (naughtyList[j] == naughtyList[j + 2])
                {
                    oneapart = true;
                }
            }
            for (int p = 0; p < naughtyList.Count() - 1; p++)
            {
                if (naughtyList.Substring(p + 2).Contains(naughtyList.Substring(p, 2)))
                {
                    twochars = true;
                    var s1 = naughtyList.Substring(p + 2);
                    var s2 = naughtyList.Substring(p, 2);
                }
            }
            return oneapart && twochars;
        }
        public string[] input2 = File.ReadAllLines("../../day5.txt");
    }
}
