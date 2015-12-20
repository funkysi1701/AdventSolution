using System.Linq;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using System;
using System.IO;

namespace Advent
{
    public class day8
    {
        public int doSomething()
        {
            int part1 = words.Sum(w => w.Length - Regex.Replace(w.Trim('"').Replace("\\\"", "A").Replace("\\\\", "B"), "\\\\x[a-f0-9]{2}", "C").Length);
            return part1;
        }
        public int doSomething2()
        {
            int part2 = words.Sum(w => w.Replace("\\", "AA").Replace("\"", "BB").Length + 2 - w.Length);
            return part2;
        }
        public string[] words = File.ReadAllLines("../../day8.txt");

        public static void day_8()
        {
            //Day 8 Challenge
            day8 d8 = new day8();
            Console.WriteLine("Day 8"); 
            Console.ReadLine();
            Console.WriteLine(d8.doSomething());
            Console.ReadLine();
            Console.WriteLine(d8.doSomething2());
            Console.ReadLine();
        }
    }
}
