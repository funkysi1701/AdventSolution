using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day17
    {
        public int[] containers = new int[] {50,44,11,49,42,46,18,32,26,40,21,7,18,43,10,47,36,24,22,40};

        public int CountCombinations()
        {
            int total = 150;
            int count = 0;
            for (int i = 0; i < containers.Length; i++)
            {
                for (int j = 0; j < containers.Length; j++)
                {
                    if (i == j) continue;
                    for (int k = 0; k < containers.Length; k++)
                    {
                        if (i == k) continue;
                        if (j == k) continue;
                        for (int l = 0; l < containers.Length; l++)
                        {
                            if (i == l) continue;
                            if (j == l) continue;
                            if (k == l) continue;
                            for (int m = 0; m < containers.Length; m++)
                            {
                                if (i == m) continue;
                                if (j == m) continue;
                                if (k == m) continue;
                                if(l == m) continue;
                                for (int n = 0; n < containers.Length; n++)
                                {
                                    if (i == n) continue;
                                    if (j == n) continue;
                                    if (k == n) continue;
                                    if (l == n) continue;
                                    if (m == n) continue;
                                    for (int p = 0; p < containers.Length; p++)
                                    {
                                        if (i == p) continue;
                                        if (j == p) continue;
                                        if (k == p) continue;
                                        if (l == p) continue;
                                        if (m == p) continue;
                                        if (n == p) continue;
                                        for (int q = 0; q < containers.Length; q++)
                                        {
                                            if (i == q) continue;
                                            if (j == q) continue;
                                            if (k == q) continue;
                                            if (l == q) continue;
                                            if (m == q) continue;
                                            if (n == q) continue;
                                            if (p == q) continue;
                                            for (int r = 0; r < containers.Length; r++)
                                            {
                                                if (i == r) continue;
                                                if (j == r) continue;
                                                if (i == r) continue;
                                                if (i == r) continue;
                                                if (i == r) continue;
                                                if (i == r) continue;
                                                if (i == r) continue;
                                                if (i == r) continue;
                                                for (int s = 0; s < containers.Length; s++)
                                                {
                                                    if (i == s) continue;
                                                    if (j == s) continue;
                                                    if (k == s) continue;
                                                    if (l == s) continue;
                                                    if (m == s) continue;
                                                    if (n == s) continue;
                                                    if (p == s) continue;
                                                    if (q == s) continue;
                                                    if (r == s) continue;
                                                    for (int t = 0; t < containers.Length; t++)
                                                    {
                                                        if (i == t) continue;
                                                        if (j == t) continue;
                                                        if (k == t) continue;
                                                        if (l == t) continue;
                                                        if (m == t) continue;
                                                        if (n == t) continue;
                                                        if (p == t) continue;
                                                        if (q == t) continue;
                                                        if (r == t) continue;
                                                        if (s == t) continue;
                                                        for (int u = 0; u < containers.Length; u++)
                                                        {
                                                            if (i == u) continue;
                                                            if (j == u) continue;
                                                            if (k == u) continue;
                                                            if (l == u) continue;
                                                            if (m == u) continue;
                                                            if (n == u) continue;
                                                            if (p == u) continue;
                                                            if (q == u) continue;
                                                            if (r == u) continue;
                                                            if (s == u) continue;
                                                            if (t == u) continue;
                                                            for (int v = 0; v < containers.Length; v++)
                                                            {
                                                                if (i == v) continue;
                                                                if (j == v) continue;
                                                                if (k == v) continue;
                                                                if (l == v) continue;
                                                                if (m == v) continue;
                                                                if (n == v) continue;
                                                                if (p == v) continue;
                                                                if (q == v) continue;
                                                                if (r == v) continue;
                                                                if (s == v) continue;
                                                                if (t == v) continue;
                                                                if (u == v) continue;
                                                                for (int w = 0; w < containers.Length; w++)
                                                                {
                                                                    if (i == w) continue;
                                                                    if (j == w) continue;
                                                                    if (k == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    if (i == w) continue;
                                                                    for (int x = 0; x < containers.Length; x++)
                                                                    {
                                                                        if (i == x) continue;
                                                                        if (j == x) continue;
                                                                        if (k == x) continue;
                                                                        if (l == x) continue;
                                                                        if (m == x) continue;
                                                                        if (n == x) continue;
                                                                        if (p == x) continue;
                                                                        if (q == x) continue;
                                                                        if (r == x) continue;
                                                                        if (s == x) continue;
                                                                        if (t == x) continue;
                                                                        if (u == x) continue;
                                                                        if (v == x) continue;
                                                                        if (w == x) continue;
                                                                        for (int y = 0; y < containers.Length; y++)
                                                                        {
                                                                            if (i == y) continue;
                                                                            if (j == y) continue;
                                                                            if (k == y) continue;
                                                                            if (l == y) continue;
                                                                            if (m == y) continue;
                                                                            if (n == y) continue;
                                                                            if (p == y) continue;
                                                                            if (q == y) continue;
                                                                            if (r == y) continue;
                                                                            if (s == y) continue;
                                                                            if (t == y) continue;
                                                                            if (u == y) continue;
                                                                            if (v == y) continue;
                                                                            if (w == y) continue;
                                                                            if (x == y) continue;
                                                                            for (int z = 0; z < containers.Length; z++)
                                                                            {
                                                                                if (i == z) continue;
                                                                                if (j == z) continue;
                                                                                if (k == z) continue;
                                                                                if (l == z) continue;
                                                                                if (m == z) continue;
                                                                                if (n == z) continue;
                                                                                if (p == z) continue;
                                                                                if (q == z) continue;
                                                                                if (r == z) continue;
                                                                                if (s == z) continue;
                                                                                if (t == z) continue;
                                                                                if (u == z) continue;
                                                                                if (v == z) continue;
                                                                                if (w == z) continue;
                                                                                if (x == z) continue;
                                                                                if (y == z) continue;
                                                                                for (int a = 0; a < containers.Length; a++)
                                                                                {
                                                                                    if (i == a) continue;
                                                                                    if (j == a) continue;
                                                                                    if (k == a) continue;
                                                                                    if (l == a) continue;
                                                                                    if (m == a) continue;
                                                                                    if (n == a) continue;
                                                                                    if (p == a) continue;
                                                                                    if (q == a) continue;
                                                                                    if (r == a) continue;
                                                                                    if (s == a) continue;
                                                                                    if (t == a) continue;
                                                                                    if (u == a) continue;
                                                                                    if (v == a) continue;
                                                                                    if (w == a) continue;
                                                                                    if (x == a) continue;
                                                                                    if (y == a) continue;
                                                                                    if (z == a) continue;
                                                                                    for (int b = 0; b < containers.Length; b++)
                                                                                    {
                                                                                        if (i == b) continue;
                                                                                        if (j == b) continue;
                                                                                        if (k == b) continue;
                                                                                        if (l == b) continue;
                                                                                        if (m == b) continue;
                                                                                        if (n == b) continue;
                                                                                        if (p == b) continue;
                                                                                        if (q == b) continue;
                                                                                        if (r == b) continue;
                                                                                        if (s == b) continue;
                                                                                        if (t == b) continue;
                                                                                        if (u == b) continue;
                                                                                        if (v == b) continue;
                                                                                        if (w == b) continue;
                                                                                        if (x == b) continue;
                                                                                        if (y == b) continue;
                                                                                        if (z == b) continue;
                                                                                        if (a == b) continue;
                                                                                        for (int c = 0; c < containers.Length; c++)
                                                                                        {
                                                                                            total = 150;
                                                                                            if (i == c) continue;
                                                                                            if (j == c) continue;
                                                                                            if (k == c) continue;
                                                                                            if (l == c) continue;
                                                                                            if (m == c) continue;
                                                                                            if (n == c) continue;
                                                                                            if (p == c) continue;
                                                                                            if (q == c) continue;
                                                                                            if (r == c) continue;
                                                                                            if (s == c) continue;
                                                                                            if (t == c) continue;
                                                                                            if (u == c) continue;
                                                                                            if (v == c) continue;
                                                                                            if (w == c) continue;
                                                                                            if (x == c) continue;
                                                                                            if (y == c) continue;
                                                                                            if (z == c) continue;
                                                                                            if (a == c) continue;
                                                                                            if (b == c) continue;
                                                                                            total = total - containers[i];
                                                                                            if(total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[j];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[k];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[l];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[m];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[n];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[p];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[q];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[r];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[s];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[t];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[u];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[v];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[w];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[x];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[y];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[z];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[a];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[b];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                            total = total - containers[c];
                                                                                            if (total == 0) { count++; continue; }
                                                                                            if (total < 0) { continue; }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
