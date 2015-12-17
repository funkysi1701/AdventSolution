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

        public int trythis(int q)
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
                if (total == 0) { count++; total = 150; used[pos] = containers[i]; continue; }
                if (total < 0) { continue; }
                if (total > 0) { used[pos] = containers[i]; trythis(0); }
            }
            int v = containers.ToList().IndexOf(used[pos - 1]);
            if (pos>0) used[pos - 1] = 0;
            trythis(v+1);
            return count;
        }
    }
}
