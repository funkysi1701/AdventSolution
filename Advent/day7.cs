using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day7
    {
        public int logicgate(string input)
        {
            string[] input2 = input.Split('-');
            input2[1] = input2[1].Substring(2);
            if (input2[0].Contains("NOT"))
            {
                input2[0] = input2[0].Substring(4);
                input2[0] = input2[0].Trim();
                input2[1] = input2[1].Trim();
                logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] = ~(logic[stringToInt(input2[0].Substring(0, 1)), stringToInt(input2[0].Substring(1))]);
                if (logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] < 0) { logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] = 65536 + logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))]; }
            }
            else if (input2[0].Contains("OR"))
            {
                string[] input3 = input2[0].Split('O');
                input3[1] = input3[1].Substring(2);
                input3[0] = input3[0].Trim();
                input3[1] = input3[1].Trim();
                logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] = (logic[stringToInt(input3[0].Substring(0, 1)), stringToInt(input3[0].Substring(1))] | logic[stringToInt(input3[1].Substring(0, 1)), stringToInt(input3[1].Substring(1))]);
            }
            else if (input2[0].Contains("AND"))
            {
                string[] input3 = input2[0].Split('A');
                input3[1] = input3[1].Substring(2);
                input3[0] = input3[0].Trim();
                input3[1] = input3[1].Trim();
                logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] = (logic[stringToInt(input3[0].Substring(0, 1)), stringToInt(input3[0].Substring(1))] & logic[stringToInt(input3[1].Substring(0, 1)), stringToInt(input3[1].Substring(1))]);
            }
            else if (input2[0].Contains("RSHIFT"))
            {
                string[] input3 = input2[0].Split('R');
                input3[1] = input3[1].Substring(6);
                input3[0] = input3[0].Trim();
                input3[1] = input3[1].Trim();
                logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] = (logic[stringToInt(input3[0].Substring(0, 1)), stringToInt(input3[0].Substring(1))] >> Convert.ToInt32(input3[1]));
            }
            else if (input2[0].Contains("LSHIFT"))
            {
                string[] input3 = input2[0].Split('L');
                input3[1] = input3[1].Substring(6);
                input3[0] = input3[0].Trim();
                input3[1] = input3[1].Trim();
                logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] = (logic[stringToInt(input3[0].Substring(0, 1)), stringToInt(input3[0].Substring(1))] << Convert.ToInt32(input3[1]));
            }
            else if (input2[0].Any(char.IsDigit))
            {
                logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] = Convert.ToInt32(input2[0]);
            }
            else logic[stringToInt(input2[1].Substring(0, 1)), stringToInt(input2[1].Substring(1))] = logic[stringToInt(input2[0].Substring(0, 1)), stringToInt(input2[0].Substring(1))];
            return logic[1, 0];
        }
        public int[,] logic = new int[27, 27];

        public int stringToInt(string value)
        {
            int result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case 'a':
                        result = result + 1;
                        break;
                    case 'b':
                        result = result + 2;
                        break;
                    case 'c':
                        result = result + 3;
                        break;
                    case 'd':
                        result = result + 4;
                        break;
                    case 'e':
                        result = result + 5;
                        break;
                    case 'f':
                        result = result + 6;
                        break;
                    case 'g':
                        result = result + 7;
                        break;
                    case 'h':
                        result = result + 8;
                        break;
                    case 'i':
                        result = result + 9;
                        break;
                    case 'j':
                        result = result + 10;
                        break;
                    case 'k':
                        result = result + 11;
                        break;
                    case 'l':
                        result = result + 12;
                        break;
                    case 'm':
                        result = result + 13;
                        break;
                    case 'n':
                        result = result + 14;
                        break;
                    case 'o':
                        result = result + 15;
                        break;
                    case 'p':
                        result = result + 16;
                        break;
                    case 'q':
                        result = result + 17;
                        break;
                    case 'r':
                        result = result + 18;
                        break;
                    case 's':
                        result = result + 19;
                        break;
                    case 't':
                        result = result + 20;
                        break;
                    case 'u':
                        result = result + 21;
                        break;
                    case 'v':
                        result = result + 22;
                        break;
                    case 'w':
                        result = result + 23;
                        break;
                    case 'x':
                        result = result + 24;
                        break;
                    case 'y':
                        result = result + 25;
                        break;
                    case 'z':
                        result = result + 26;
                        break;
                    default:
                        result = result + 0;
                        break;
                }
            }
            return result;
        }

        public string sortList()
        {
            string[] sorted = new string[339];
            sorted[0] = input4[0];
            // numbersList;
            for (int i = 0; i < input4.Length; i++)
            {
                sorted[i] = search(input4[i]);
                var numbersList = input4.ToList();
                numbersList.Remove(input4[i]);
                input4 = numbersList.ToArray();
            }
            return sorted[1];
        }
        public string search(string input)
        {
            string[] a = input.Split('-');
            string search = a[1].Substring(2);
            int index;
            for (int i = 0; i < input4.Length; i++)
            {
                index = input4[i].IndexOf(search);
                if (index >= 0)
                {
                    return input4[index]; 
                }
            }
            return "";
        }

        public string[] input4 = File.ReadAllLines("../../day7.txt");
        public static void day_7()
        {
            //Day 7 Challenge
            day7 d7 = new day7();
            Console.WriteLine("Day 7");
            Console.ReadLine();
            Console.WriteLine(d7.sortList());
            Console.ReadLine();
            for (int i = 0; i < d7.input4.Length; i++)
            {
                d7.logicgate(d7.input4[i]);
            }
            Console.WriteLine(d7.logic[1, 0]);
            Console.ReadLine();
        }
    }
}
