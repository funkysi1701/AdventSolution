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
            logic[0] = 123;
            stringToInt("x");
            stringToInt("y");
        }
        public int[] logic = new int[7];

        public int stringToInt(string value)
        {
            return Convert.ToInt32(value);
        }
        public string[] input4 = new string[7] {
"123 -> x",
"456->y",
"x AND y->d",
"x OR y->e",
"x LSHIFT 2->f",
"NOT x -> h",
"NOT y->i"};
    }
}
