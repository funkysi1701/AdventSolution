using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Program
    {
        //http://adventofcode.com/

        public static void Main(string[] args)
        {
            Console.Write("Enter any Key: ");
            int name = Console.Read();
            switch (name)
            {
                case 49: day1(); break;
                case 50: day2(); break;
                case 51: day3(); break;
                case 52: day4(); break;
                case 53: day5(); break;
                case 54: day6(); break;
                case 55: day7(); break;
                case 56: day8(); break;
                //case 9: day9(); break;
                //case 10: day10(); break;
                default: break;
            }
        }
        public static void day1()
        {
            //Day 1 Challenge
            day1 d1 = new day1();
            d1.count = d1.count + d1.UpDown(d1.input);
            Console.WriteLine("Day 1");
            Console.ReadLine();
            Console.WriteLine(d1.count);
            Console.ReadLine();
            Console.WriteLine(d1.Basement(d1.input));
            Console.ReadLine();
        }
        public static void day2()
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
        public static void day3()
        {
            //Day 3 Challenge
            day3 d3 = new day3();
            Console.WriteLine("Day 3");
            Console.ReadLine();
            Console.WriteLine(d3.HouseVisit(d3.input));
            Console.ReadLine();
            Console.WriteLine(d3.HouseVisit2(d3.input));
            Console.ReadLine();
        }
        public static void day4()
        {
            //Day 4 Challenge
            day4 d4 = new day4();
            Console.WriteLine("Day 4");
            Console.ReadLine();
            Console.WriteLine(d4.adventcoins(d4.input));
            Console.ReadLine();
            Console.WriteLine(d4.adventcoins2(d4.input));
            Console.ReadLine();
        }
        public static void day5()
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
        public static void day6()
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
        public static void day7()
        {
            //Day 7 Challenge
            day7 d7 = new day7();
            Console.WriteLine("Day 7");
            Console.ReadLine();
            for (int i = 0; i < d7.input4.Length; i++)
            {
                d7.logicgate(d7.input4[i]);
            }
            Console.WriteLine(d7.logic[1, 0]);
            Console.ReadLine();
        }
        public static void day8()
        {
            //Day 8 Challenge
            day8 d8 = new day8();
            Console.WriteLine("Day 8"); //Between 510 and 5150
            Console.ReadLine();
            for (int i = 0; i < d8.input2.Length; i++)
            {
                Console.WriteLine(d8.rawLength(d8.input2[i]));
                Console.WriteLine(d8.actualLength(d8.input2[i]));
            }
            Console.ReadLine();
        }
    }
}
