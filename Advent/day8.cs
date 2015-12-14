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
        public string[] words = File.ReadAllLines("C:/projects/AdventSolution/Advent/day8.txt");
    }
}
