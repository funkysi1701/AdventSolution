using System;

namespace Advent
{
    public class Program
    {
        //http://adventofcode.com/

        public static void Main(string[] args)
        {
            Console.Write("Choose which advent code to run (1-25): ");
            string name = Console.ReadLine();
            switch (name)
            {
                case "1": day1.day_1(); break;
                case "2": day2.day_2(); break;
                case "3": day3.day_3(); break;
                case "4": day4.day_4(); break;
                case "5": day5.day_5(); break;
                case "6": day6.day_6(); break;
                case "7": day7.day_7(); break;
                case "8": day8.day_8(); break;
                case "9": day9.day_9(); break;
                case "10": day10.day_10(); break;
                case "11": day11.day_11(); break;
                case "12": day12.day_12(); break;
                case "13": day13.day_13(); break;
                case "14": day14.day_14(); break;
                case "15": day15.day_15(); break;
                case "16": day16.day_16(); break;
                case "17": day17.day_17(); break;
                case "18": day18.day_18(); break;
                case "19": day19.day_19(); break;
                case "20": day20.day_20(); break;
                case "21": day21.day_21(); break;
                case "22": day22.day_22(); break;
                case "23": day23.day_23(); break;
                case "24": day24.day_24(); break;
                case "25": day25.day_25(); break;
                default: break;
            }
        }
    }
}
