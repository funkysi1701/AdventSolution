using System;
using System.Text;
using System.Security.Cryptography;

namespace Advent
{
    public class day4
    {
        public string input = "yzbqklnj";
        public static void day_4()
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
        public string adventcoins2(string input)
        {
            for (int i = 0; i < 10489710; i++)
            {
                string j = i.ToString();
                string newinput = input + j;
                string hash = CalculateMD5Hash(newinput);
                if (hash.Substring(0, 6) == "000000") return j;
            }
            return "never found try more loops";
        }

        public string adventcoins(string input)
        {
            for (int i = 0; i < 1048971; i++)
            {
                string j = i.ToString();
                string newinput = input + j;
                string hash = CalculateMD5Hash(newinput);
                if (hash.Substring(0, 5) == "00000") return j;
            }
            return "never found try more loops";
        }

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
