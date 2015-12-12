using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day10
    {
        public string input = "1113122113";

        public string parseNumbers(string input)
        {
            int inputLength = input.Length;
            string tmp = "";
            for (int i = 0; i < inputLength; i++)
            {
                if (inputLength == 1) return "1" + input;
                if (inputLength > 1)
                {
                    if (i < inputLength - 2 && input[i] == input[i + 1] && input[i + 1] == input[i + 2]) { tmp = tmp + "3" + input[i]; i++; i++; continue; }
                    if (i < inputLength - 1 && input[i] == input[i + 1]) { tmp = tmp + "2" + input[i]; i++; continue; }
                    if (i < inputLength - 1 && input[i] != input[i + 1])
                    {
                        tmp = tmp + "1" + input[i];
                        if (i == inputLength - 2)
                        {
                            tmp = tmp + "1" + input[i + 1];
                            i++;
                            continue;
                        }
                    }
                    if (i == inputLength - 1) tmp = tmp + "1" + input[i];
                }


            }
            return tmp;
        }
    }
}
