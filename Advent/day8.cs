using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day8
    {
        public string input = @"byc\x9dyxuafof\\\xa6uf\\axfozomj\\olh\x6a";

        public int rawLength(string input)
        {
            return input.Length;
        }

        public int actualLength(string input)
        {
            string escape1 = "\\";
            string escape2 = "\\";

            int count = 0;
            int length = rawLength(input);

            for (int i = 0; i < length; i++)
            {
                //if (input.Substring(i, 1).Contains("\x")) count++;
                if (input.Substring(i, 1) == escape2) count++;
                //if (input.Substring(i, 1) == escape3) count++;
            }
            return count;
        }
    }
}
