using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day7
    {
        public void logicgate(string input)
        {
            string[] input2 = input.Split('-');
            input2[1] = input2[1].Substring(2);
            if (input2[0].Contains("NOT")) {
                
                input2[0] = input2[0].Substring(4);
                input2[0] = input2[0].Trim();
                input2[1] = input2[1].Trim();
                logic[stringToInt(input2[1])] = ~(logic[stringToInt(input2[0])]);
                if (logic[stringToInt(input2[1])] < 0) { logic[stringToInt(input2[1])] = 65536 + logic[stringToInt(input2[1])]; }
            }
            else if (input2[0].Contains("OR")) {
                string[] input3 = input2[0].Split('O');
                input3[1] = input3[1].Substring(2);
                input3[0] = input3[0].Trim();
                input3[1] = input3[1].Trim();
                logic[stringToInt(input2[1])] = (logic[stringToInt(input3[0])] | logic[stringToInt(input3[1])]);
            }
            else if (input2[0].Contains("AND")) {
                string[] input3 = input2[0].Split('A');
                input3[1] = input3[1].Substring(2);
                input3[0] = input3[0].Trim();
                input3[1] = input3[1].Trim();
                logic[stringToInt(input2[1])] = (logic[stringToInt(input3[0])] & logic[stringToInt(input3[1])]);
            }
            else if (input2[0].Contains("RSHIFT")) {
                string[] input3 = input2[0].Split('R');
                input3[1] = input3[1].Substring(6);
                input3[0] = input3[0].Trim();
                input3[1] = input3[1].Trim();
                logic[stringToInt(input2[1])] = (logic[stringToInt(input3[0])] >> Convert.ToInt32(input3[1]));
            }
            else if (input2[0].Contains("LSHIFT")) {
                string[] input3 = input2[0].Split('L');
                input3[1] = input3[1].Substring(6);
                input3[0] = input3[0].Trim();
                input3[1] = input3[1].Trim();
                logic[stringToInt(input2[1])] = (logic[stringToInt(input3[0])] << Convert.ToInt32(input3[1]));
            }
            else logic[stringToInt(input2[1])] = Convert.ToInt32(input2[0]);
        }
        public int[] logic = new int[53];

        public int stringToInt(string value)
        {
            int result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case 'a':
                        result = result+ 1;
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
        public string[] input4 = new string[7] {
"123 -> x",
"456 -> y",
"x AND y -> d",
"x OR y -> e",
"x LSHIFT 2 -> f",
"NOT x -> h",
"NOT y -> i"};
    }
}
