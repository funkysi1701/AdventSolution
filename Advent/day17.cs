using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day17
    {
        public int[] containers = new int[] { 50, 44, 11, 49, 42, 46, 18, 32, 26, 40, 21, 7, 18, 43, 10, 47, 36, 24, 22, 40 };
        public int total = 150;
        public int count = 0;
        public int[] used = new int[10];
        public static void day_17()
        {
            //Day 17 Challenge
            day17 d17 = new day17();
            Console.WriteLine("Day 17");
            Console.ReadLine();
            Console.WriteLine(d17.main());
            Console.ReadLine();
        }
        public int calcTotal(int q)
        {
            int pos=0;
            for (int j = 0; j < used.Length; j++)
            {
                if (used[j] > 0) pos = j+1;
            }
            for (int i = q; i < containers.Length; i++)
            {
                bool a = false;
                for (int tmp = 0; tmp < pos; tmp++)
                {
                    if (containers[i] == used[tmp]) a = true;
                }
                if (a) continue;
                total = (150 - used.Sum()) - containers[i];
            }

            return total;
        }

        public string main()
        {
            int q = calcTotal(0);
            while (q > 0)
            {
                q= calcTotal(0);
            }
            if (q == 0) count++;
            if (q < 0)
            {
                //total is -ve
            }
            return "";
        }
    }
}
