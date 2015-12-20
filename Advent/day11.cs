using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day11
    {
        public static void day_11()
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
            d11.input = d11.incrementString(d11.input);
            while (!d11.ValidString(d11.input))
            {
                d11.input = d11.incrementString(d11.input);
            }
            Console.WriteLine(d11.input);
            Console.ReadLine();
        }
        public string input = "cqjxjnds";
        public string incrementString(string input)
        {
            string tmp = "";
            switch (input[input.Length - 1])
            {
                case 'a': input = input.Remove(input.Length - 1, 1) + "b"; break;
                case 'b': input = input.Remove(input.Length - 1, 1) + "c"; break;
                case 'c': input = input.Remove(input.Length - 1, 1) + "d"; break;
                case 'd': input = input.Remove(input.Length - 1, 1) + "e"; break;
                case 'e': input = input.Remove(input.Length - 1, 1) + "f"; break;
                case 'f': input = input.Remove(input.Length - 1, 1) + "g"; break;
                case 'g': input = input.Remove(input.Length - 1, 1) + "h"; break;
                case 'h': input = input.Remove(input.Length - 1, 1) + "i"; break;
                case 'i': input = input.Remove(input.Length - 1, 1) + "j"; break;
                case 'j': input = input.Remove(input.Length - 1, 1) + "k"; break;
                case 'k': input = input.Remove(input.Length - 1, 1) + "l"; break;
                case 'l': input = input.Remove(input.Length - 1, 1) + "m"; break;
                case 'm': input = input.Remove(input.Length - 1, 1) + "n"; break;
                case 'n': input = input.Remove(input.Length - 1, 1) + "o"; break;
                case 'o': input = input.Remove(input.Length - 1, 1) + "p"; break;
                case 'p': input = input.Remove(input.Length - 1, 1) + "q"; break;
                case 'q': input = input.Remove(input.Length - 1, 1) + "r"; break;
                case 'r': input = input.Remove(input.Length - 1, 1) + "s"; break;
                case 's': input = input.Remove(input.Length - 1, 1) + "t"; break;
                case 't': input = input.Remove(input.Length - 1, 1) + "u"; break;
                case 'u': input = input.Remove(input.Length - 1, 1) + "v"; break;
                case 'v': input = input.Remove(input.Length - 1, 1) + "w"; break;
                case 'w': input = input.Remove(input.Length - 1, 1) + "x"; break;
                case 'x': input = input.Remove(input.Length - 1, 1) + "y"; break;
                case 'y': input = input.Remove(input.Length - 1, 1) + "z"; break;
                case 'z': input = incrementString(input.Remove(input.Length - 1, 1)); tmp = tmp + "a"; break;
                default:
                    break;
            }
            return input + tmp;
        }

        public bool ValidString(string input)
        {
            int count = 0;
            int char3 = 0;
            if (input.Contains("i")) { return false; }
            if (input.Contains("o")) { return false; }
            if (input.Contains("l")) { return false; }
            for (int i = 0; i < input.Length - 2; i++)
            {
                if (input[i] + 1 == input[i + 1] && input[i + 1] + 1 == input[i + 2]) { char3++; }
            }
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input = input.Remove(i, 2);
                    input = input.Insert(i, "12");
                    count++;
                }
            }
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input = input.Remove(i, 2);
                    input = input.Insert(i, "34");
                    count++;
                }
            }
            if (count < 2) return false;
            if (char3 > 0) return true;
            return false;
        }
    }
}
