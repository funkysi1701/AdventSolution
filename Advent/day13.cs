using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day13
    {
        public enum Guests
        {
            Alice = 0,
            Bob = 1,
            Carol = 2,
            David = 3,
            Eric = 4,
            Frank = 5,
            George = 6,
            Mallory = 7
        }
        public int[,] Happyness = new int[8, 8];

        public void setup()
        {
            string[] input = new string[56] {
"Alice would lose 57 happiness units by sitting next to Bob.",
"Alice would lose 62 happiness units by sitting next to Carol.",
"Alice would lose 75 happiness units by sitting next to David.",
"Alice would gain 71 happiness units by sitting next to Eric.",
"Alice would lose 22 happiness units by sitting next to Frank.",
"Alice would lose 23 happiness units by sitting next to George.",
"Alice would lose 76 happiness units by sitting next to Mallory.",
"Bob would lose 14 happiness units by sitting next to Alice.",
"Bob would gain 48 happiness units by sitting next to Carol.",
"Bob would gain 89 happiness units by sitting next to David.",
"Bob would gain 86 happiness units by sitting next to Eric.",
"Bob would lose 2 happiness units by sitting next to Frank.",
"Bob would gain 27 happiness units by sitting next to George.",
"Bob would gain 19 happiness units by sitting next to Mallory.",
"Carol would gain 37 happiness units by sitting next to Alice.",
"Carol would gain 45 happiness units by sitting next to Bob.",
"Carol would gain 24 happiness units by sitting next to David.",
"Carol would gain 5 happiness units by sitting next to Eric.",
"Carol would lose 68 happiness units by sitting next to Frank.",
"Carol would lose 25 happiness units by sitting next to George.",
"Carol would gain 30 happiness units by sitting next to Mallory.",
"David would lose 51 happiness units by sitting next to Alice.",
"David would gain 34 happiness units by sitting next to Bob.",
"David would gain 99 happiness units by sitting next to Carol.",
"David would gain 91 happiness units by sitting next to Eric.",
"David would lose 38 happiness units by sitting next to Frank.",
"David would gain 60 happiness units by sitting next to George.",
"David would lose 63 happiness units by sitting next to Mallory.",
"Eric would gain 23 happiness units by sitting next to Alice.",
"Eric would lose 69 happiness units by sitting next to Bob.",
"Eric would lose 33 happiness units by sitting next to Carol.",
"Eric would lose 47 happiness units by sitting next to David.",
"Eric would gain 75 happiness units by sitting next to Frank.",
"Eric would gain 82 happiness units by sitting next to George.",
"Eric would gain 13 happiness units by sitting next to Mallory.",
"Frank would gain 77 happiness units by sitting next to Alice.",
"Frank would gain 27 happiness units by sitting next to Bob.",
"Frank would lose 87 happiness units by sitting next to Carol.",
"Frank would gain 74 happiness units by sitting next to David.",
"Frank would lose 41 happiness units by sitting next to Eric.",
"Frank would lose 99 happiness units by sitting next to George.",
"Frank would gain 26 happiness units by sitting next to Mallory.",
"George would lose 63 happiness units by sitting next to Alice.",
"George would lose 51 happiness units by sitting next to Bob.",
"George would lose 60 happiness units by sitting next to Carol.",
"George would gain 30 happiness units by sitting next to David.",
"George would lose 100 happiness units by sitting next to Eric.",
"George would lose 63 happiness units by sitting next to Frank.",
"George would gain 57 happiness units by sitting next to Mallory.",
"Mallory would lose 71 happiness units by sitting next to Alice.",
"Mallory would lose 28 happiness units by sitting next to Bob.",
"Mallory would lose 10 happiness units by sitting next to Carol.",
"Mallory would gain 44 happiness units by sitting next to David.",
"Mallory would gain 22 happiness units by sitting next to Eric.",
"Mallory would gain 79 happiness units by sitting next to Frank.",
"Mallory would lose 16 happiness units by sitting next to George."
};
            for (int i = 0; i < input.Length; i++)
            {
                string tmp = input[i];
                int v = -1;
                int w = -1;
                tmp = tmp.Replace("would lose ", "-");
                tmp = tmp.Replace("would gain", "");
                tmp = tmp.Replace("happiness units by sitting next to ", "");
                if (tmp.StartsWith("Alice"))
                {
                    tmp = tmp.Replace("Alice", "");
                    w = Guest("Alice", tmp);
                }
                else if (tmp.StartsWith("Bob"))
                {
                    tmp = tmp.Replace("Bob", "");
                    w = Guest("Bob", tmp);
                }
                else if (tmp.StartsWith("Carol"))
                {
                    tmp = tmp.Replace("Carol", "");
                    w = Guest("Carol", tmp);
                }
                else if (tmp.StartsWith("David"))
                {
                    tmp = tmp.Replace("David", "");
                    w = Guest("David", tmp);
                }
                else if (tmp.StartsWith("Eric"))
                {
                    tmp = tmp.Replace("Eric", "");
                    w = Guest("Eric", tmp);
                }
                else if (tmp.StartsWith("Frank"))
                {
                    tmp = tmp.Replace("Frank", "");
                    w = Guest("Frank", tmp);
                }
                else if (tmp.StartsWith("George"))
                {
                    tmp = tmp.Replace("George", "");
                    w = Guest("George", tmp);
                }
                else if (tmp.StartsWith("Mallory"))
                {
                    tmp = tmp.Replace("Mallory", "");
                    w = Guest("Mallory", tmp);
                }
                if (tmp.Contains("Alice"))
                {
                    tmp = tmp.Replace("Alice", "");
                    tmp = tmp.Replace(".", "");
                    tmp = tmp.Trim();
                    v = Guest("Alice", tmp);
                }
                else if (tmp.Contains("Bob"))
                {
                    tmp = tmp.Replace("Bob", "");
                    tmp = tmp.Replace(".", "");
                    tmp = tmp.Trim();
                    v = Guest("Bob", tmp);
                }
                else if (tmp.Contains("Carol"))
                {
                    tmp = tmp.Replace("Carol", "");
                    tmp = tmp.Replace(".", "");
                    tmp = tmp.Trim();
                    v = Guest("Carol", tmp);
                }
                else if (tmp.Contains("David"))
                {
                    tmp = tmp.Replace("David", "");
                    tmp = tmp.Replace(".", "");
                    tmp = tmp.Trim();
                    v = Guest("David", tmp);
                }
                else if (tmp.Contains("Eric"))
                {
                    tmp = tmp.Replace("Eric", "");
                    tmp = tmp.Replace(".", "");
                    tmp = tmp.Trim();
                    v = Guest("Eric", tmp);
                }
                else if (tmp.Contains("Frank"))
                {
                    tmp = tmp.Replace("Frank", "");
                    tmp = tmp.Replace(".", "");
                    tmp = tmp.Trim();
                    v = Guest("Frank", tmp);
                }
                else if (tmp.Contains("George"))
                {
                    tmp = tmp.Replace("George", "");
                    tmp = tmp.Replace(".", "");
                    tmp = tmp.Trim();
                    v = Guest("George", tmp);
                }
                else if (tmp.Contains("Mallory"))
                {
                    tmp = tmp.Replace("Mallory", "");
                    tmp = tmp.Replace(".", "");
                    tmp = tmp.Trim();
                    v = Guest("Mallory", tmp);
                }
                Happyness[w, v] = Convert.ToInt32(tmp); 
            }
        }
        public int CalcHappy()
        {
            int[] happyTotal = new int[16000000];
            int count=0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == j) continue;
                    for (int k = 0; k < 8; k++)
                    {
                        if (i == k) continue;
                        if (j == k) continue;
                        for (int l = 0; l < 8; l++)
                        {
                            if (i == l) continue;
                            if (j == l) continue;
                            if (k == l) continue;
                            for (int m = 0; m < 8; m++)
                            {
                                if (i == m) continue;
                                if (j == m) continue;
                                if (k == m) continue;
                                if (l == m) continue;
                                for (int n = 0; n < 8; n++)
                                {
                                    if (i == n) continue;
                                    if (j == n) continue;
                                    if (k == n) continue;
                                    if (l == n) continue;
                                    if (m == n) continue;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (i == p) continue;
                                        if (j == p) continue;
                                        if (k == p) continue;
                                        if (l == p) continue;
                                        if (m == p) continue;
                                        if (n == p) continue;
                                        for (int q = 0; q < 8; q++)
                                        {
                                            if (i == q) continue;
                                            if (j == q) continue;
                                            if (k == q) continue;
                                            if (l == q) continue;
                                            if (m == q) continue;
                                            if (n == q) continue;
                                            if (p == q) continue;
                                            happyTotal[count] = Happyness[i, j] + Happyness[j, i] + 
                                                Happyness[j, k] + Happyness[k, j] + 
                                                Happyness[k, l] + Happyness[l, k] + 
                                                Happyness[l, m] + Happyness[m, l] + 
                                                Happyness[m, n] + Happyness[n, m] + 
                                                Happyness[n, p] + Happyness[p, n] + 
                                                Happyness[p, q] + Happyness[q, p] + 
                                                Happyness[q, i] + Happyness[i, q];
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return happyTotal.Max();
        }
        public int Guest(string name, string tmp)
        {
            switch (name)
            {
                case "Alice": return (int)Guests.Alice;
                case "Bob": return (int)Guests.Bob;
                case "Carol": return (int)Guests.Carol;
                case "David": return (int)Guests.David;
                case "Eric": return (int)Guests.Eric;
                case "Frank": return (int)Guests.Frank;
                case "George": return (int)Guests.George;
                case "Mallory": return (int)Guests.Mallory;
                default:
                    return -1;
            }
        }
    }
}
