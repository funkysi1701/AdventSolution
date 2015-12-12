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
                case "1": day1(); break;
                case "2": day2(); break;
                case "3": day3(); break;
                case "4": day4(); break;
                case "5": day5(); break;
                case "6": day6(); break;
                case "7": day7(); break;
                case "8": day8(); break;
                case "9": day9(); break;
                case "10": day10(); break;
                case "11": day11(); break;
                case "12": day12(); break;
                case "13": day13(); break;
                case "14": day14(); break;
                case "15": day15(); break;
                case "16": day16(); break;
                case "17": day17(); break;
                case "18": day18(); break;
                case "19": day19(); break;
                case "20": day20(); break;
                case "21": day21(); break;
                case "22": day22(); break;
                case "23": day23(); break;
                case "24": day24(); break;
                case "25": day25(); break;
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
                d8.total = d8.total + (d8.rawLength(d8.input2[i])) - (d8.actualLength(d8.input2[i]));
                
            }
            Console.WriteLine(d8.total);
            Console.ReadLine();
        }
        public static void day9()
        {
            //Day 9 Challenge
            day9 d9 = new day9();
            Console.WriteLine("Day 9");
            Console.ReadLine();
        }
        public static void day10()
        {
            //Day 10 Challenge
            day10 d10 = new day10();
            Console.WriteLine("Day 10");
            Console.ReadLine();
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(d10.input.Length);
                d10.input = d10.parseNumbers(d10.input);
                Console.WriteLine(i);
                Console.WriteLine(DateTime.UtcNow);
            }
            Console.WriteLine(d10.input.Length);
            Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(d10.input.Length);
                d10.input = d10.parseNumbers(d10.input);
                Console.WriteLine(i+40);
                Console.WriteLine(DateTime.UtcNow);
            }
            Console.WriteLine(d10.input.Length);
            Console.ReadLine();
        }
        public static void day11()
        {
            //Day 11 Challenge
            day11 d11 = new day11();
            Console.WriteLine("Day 11");
            Console.ReadLine();
            while (!d11.ValidString(d11.input))
            {
                d11.input = d11.incrementString(d11.input);
            }
            Console.WriteLine(d11.input);
            Console.ReadLine();
        }
        public static void day12()
        {
            //Day 12 Challenge
            day12 d12 = new day12();
            Console.WriteLine("Day 12");
            Console.ReadLine();
        }
        public static void day13()
        {
            //Day 13 Challenge
            day13 d13 = new day13();
            Console.WriteLine("Day 13");
            Console.ReadLine();
        }
        public static void day14()
        {
            //Day 14 Challenge
            day14 d14 = new day14();
            Console.WriteLine("Day 14");
            Console.ReadLine();
        }
        public static void day15()
        {
            //Day 15 Challenge
            day15 d15 = new day15();
            Console.WriteLine("Day 15");
            Console.ReadLine();
        }
        public static void day16()
        {
            //Day 16 Challenge
            day16 d16 = new day16();
            Console.WriteLine("Day 16");
            Console.ReadLine();
        }
        public static void day17()
        {
            //Day 17 Challenge
            day17 d17 = new day17();
            Console.WriteLine("Day 17");
            Console.ReadLine();
        }
        public static void day18()
        {
            //Day 18 Challenge
            day18 d18 = new day18();
            Console.WriteLine("Day 18");
            Console.ReadLine();
        }
        public static void day19()
        {
            //Day 19 Challenge
            day19 d19 = new day19();
            Console.WriteLine("Day 19");
            Console.ReadLine();
        }
        public static void day20()
        {
            //Day 20 Challenge
            day20 d20 = new day20();
            Console.WriteLine("Day 20");
            Console.ReadLine();
        }
        public static void day21()
        {
            //Day 21 Challenge
            day21 d21 = new day21();
            Console.WriteLine("Day 21");
            Console.ReadLine();
        }
        public static void day22()
        {
            //Day 22 Challenge
            day22 d22 = new day22();
            Console.WriteLine("Day 22");
            Console.ReadLine();
        }
        public static void day23()
        {
            //Day 23 Challenge
            day23 d23 = new day23();
            Console.WriteLine("Day 23");
            Console.ReadLine();
        }
        public static void day24()
        {
            //Day 24 Challenge
            day24 d24 = new day24();
            Console.WriteLine("Day 24");
            Console.ReadLine();
        }
        public static void day25()
        {
            //Day 25 Challenge
            day25 d25 = new day25();
            Console.WriteLine("Day 25");
            Console.ReadLine();
        }

    }
}
