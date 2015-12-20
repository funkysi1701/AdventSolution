using System;
using System.IO;
using System.Linq;

namespace Advent
{
    public class day2
    {
        public int result = 0;
        public int result2 = 0;
        public static void day_2()
        {
            //Day 2 Challenge
            day2 d2 = new day2();
            Console.WriteLine("Day 2");
            Console.ReadLine();
            for (int i = 0; i < 1000; i++)
            {
                d2.result = d2.result + d2.area(d2.input[i]);
                d2.result2 = d2.result2 + d2.ribbon(d2.input[i]);
            }
            Console.WriteLine(d2.result);
            Console.ReadLine();
            Console.WriteLine(d2.result2);
            Console.ReadLine();
        }
        public int ribbon(string input)
        {
            int w = input.IndexOf("x");
            int width = Convert.ToInt32(input.Substring(0, w));

            int l = input.LastIndexOf("x");
            int length = Convert.ToInt32(input.Substring(w + 1, l - (w + 1)));

            int h = input.Length;
            int height = Convert.ToInt32(input.Substring(l + 1, h - (l + 1)));

            int[] smallest = new int[3] { width + width + height + height, length + length + height + height, length + length + width + width };
            int extra = smallest.Min();

            return extra + (height * width * length);

        }
        public int area(string input)
        {
            int w = input.IndexOf("x");
            int width = Convert.ToInt32(input.Substring(0, w));

            int l = input.LastIndexOf("x");
            int length = Convert.ToInt32(input.Substring(w + 1, l - (w + 1)));

            int h = input.Length;
            int height = Convert.ToInt32(input.Substring(l + 1, h - (l + 1)));

            int[] smallest = new int[3] { width * height, width * length, length * height };
            int extra = smallest.Min();

            return 2 * height * length + 2 * width * height + 2 * length * width + extra;
        }

        public string[] input = File.ReadAllLines("../../day2.txt");
    }
}
